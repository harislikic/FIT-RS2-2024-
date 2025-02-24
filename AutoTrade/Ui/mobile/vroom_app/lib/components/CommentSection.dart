import 'package:flutter/material.dart';
import 'package:vroom_app/components/ConfirmationDialog.dart';
import 'package:vroom_app/components/shared/ToastUtils.dart';
import 'package:vroom_app/services/CommentService.dart';
import 'package:vroom_app/models/comment.dart';
import 'package:vroom_app/services/AuthService.dart';
import 'package:vroom_app/services/config.dart';

/// Now a StatefulWidget so we can re-fetch comments after add/delete/edit.
class CommentsSection extends StatefulWidget {
  final int automobileAdId;

  const CommentsSection(this.automobileAdId, {Key? key}) : super(key: key);

  @override
  _CommentsSectionState createState() => _CommentsSectionState();
}

class _CommentsSectionState extends State<CommentsSection> {
  Future<List<Comment>>? _commentsFuture;

  @override
  void initState() {
    super.initState();
    _commentsFuture = _fetchComments();
  }

  Future<List<Comment>> _fetchComments() async {
    final commentService = CommentService();
    return commentService.fetchCommentsByAutomobileId(widget.automobileAdId);
  }

  void _refreshParentComments() {
    setState(() {
      _commentsFuture = _fetchComments();
    });
  }

  void _showCommentsModal(BuildContext context, List<Comment> comments) {
    showModalBottomSheet(
      context: context,
      isScrollControlled: true,
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(16)),
      builder: (BuildContext context) {
        return CommentsModalBottomSheet(
          automobileAdId: widget.automobileAdId,
          initialComments: comments,
          onParentRefresh: _refreshParentComments,
        );
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    return FutureBuilder<List<Comment>>(
      future: _commentsFuture,
      builder: (context, snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return const Center(child: CircularProgressIndicator());
        } else if (snapshot.hasError) {
          return const Text('Greška pri učitavanju komentara.');
        }

        final comments = snapshot.data ?? [];

        return GestureDetector(
          onTap: () => _showCommentsModal(context, comments),
          child: Container(
            decoration: BoxDecoration(
              border: Border.all(color: Colors.grey.shade900),
              borderRadius: BorderRadius.circular(10),
            ),
            padding: const EdgeInsets.all(12),
            child: Row(
              mainAxisAlignment: MainAxisAlignment.start,
              children: [
                const Icon(
                  Icons.question_answer_outlined,
                  color: Colors.grey,
                  size: 24,
                ),
                const SizedBox(width: 8),
                Text(
                  'PITANJA I ODGOVORI (${comments.length})',
                  style: TextStyle(
                    fontSize: 16,
                    fontWeight: FontWeight.bold,
                    color: Colors.grey.shade700,
                  ),
                ),
              ],
            ),
          ),
        );
      },
    );
  }
}

class CommentsModalBottomSheet extends StatefulWidget {
  final int automobileAdId;
  final List<Comment> initialComments;
  final VoidCallback onParentRefresh;

  const CommentsModalBottomSheet({
    Key? key,
    required this.automobileAdId,
    required this.initialComments,
    required this.onParentRefresh,
  }) : super(key: key);

  @override
  State<CommentsModalBottomSheet> createState() =>
      _CommentsModalBottomSheetState();
}

class _CommentsModalBottomSheetState extends State<CommentsModalBottomSheet> {
  late List<Comment> _comments;
  final TextEditingController _commentController = TextEditingController();

  int? _loggedInUserId;

  @override
  void initState() {
    super.initState();

    _comments = List.from(widget.initialComments);

    AuthService.getUserId().then((id) {
      setState(() {
        _loggedInUserId = id;
      });
    });
  }

  Future<void> _refreshComments() async {
    final commentService = CommentService();
    final updatedComments =
        await commentService.fetchCommentsByAutomobileId(widget.automobileAdId);
    setState(() {
      _comments.clear();
      _comments.addAll(updatedComments);
    });

    widget.onParentRefresh();
  }

  Future<void> _addComment() async {
    if (_commentController.text.isEmpty) {
      ToastUtils.showErrorToast(message: "Unesite komentar prije slanja.");
      return;
    }

    try {
      final userId = await AuthService.getUserId();
      final commentService = CommentService();
      await commentService.addComment(
        content: _commentController.text,
        userId: userId!,
        automobileAdId: widget.automobileAdId,
      );

      _commentController.clear();
      ToastUtils.showToast(message: "Komentar uspješno dodan.");

      await _refreshComments();
    } catch (e) {
      ToastUtils.showErrorToast(message: "Greška pri dodavanju komentara.");
    }
  }

  void _showEditDialog(BuildContext context, Comment comment) {
    final TextEditingController _controller =
        TextEditingController(text: comment.content);

    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Uredi komentar'),
          content: TextField(
            controller: _controller,
            decoration: const InputDecoration(hintText: 'Uredite komentar'),
            maxLines: 1,
          ),
          actions: [
            TextButton(
              onPressed: () => Navigator.pop(context),
              child: const Text('Cancel'),
            ),
            TextButton(
              onPressed: () async {
                if (_controller.text.isNotEmpty) {
                  final CommentService commentService = CommentService();
                  try {
                    await commentService.editComment(
                      commentId: comment.commentId,
                      userId: comment.user.id,
                      content: _controller.text,
                    );
                    ToastUtils.showToast(message: "Komentar editovan");

                    await _refreshComments();
                  } catch (e) {
                    ToastUtils.showErrorToast(
                      message: "Greška prilikom editovanja komentara: $e",
                    );
                  } finally {
                    Navigator.pop(context);
                  }
                }
              },
              child: const Text('Save'),
            ),
          ],
        );
      },
    );
  }

  void _showDeleteDialog(BuildContext context, Comment comment) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return ConfirmationDialog(
          title: "Potvrda brisanja",
          content: "Da li ste sigurni da želite obrisati komentar?",
          successMessage: "Komentar je uspešno obrisan.",
          onConfirm: () async {
            final CommentService commentService = CommentService();
            try {
              await commentService.deleteComment(commentId: comment.commentId);
              await _refreshComments();
            } catch (e) {
              ToastUtils.showErrorToast(message: "Greška prilikom brisanja");
              throw e;
            }
          },
          onCancel: () {},
        );
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    final isLoggedIn = (_loggedInUserId != null);

    return Padding(
      padding: EdgeInsets.only(
        bottom: MediaQuery.of(context).viewInsets.bottom,
        left: 16,
        right: 16,
        top: 50,
      ),
      child: Column(
        mainAxisSize: MainAxisSize.min,
        children: [
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              const Text(
                'Komentari',
                style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
              ),
              IconButton(
                icon: const Icon(Icons.close, color: Colors.black),
                onPressed: () => Navigator.pop(context),
              ),
            ],
          ),
          const SizedBox(height: 16),
          // List of comments
          Expanded(
            child: _comments.isEmpty
                ? const Text('Nema dostupnih komentara.')
                : ListView.builder(
                    shrinkWrap: true,
                    itemCount: _comments.length,
                    itemBuilder: (context, index) {
                      final comment = _comments[index];

                      final isOwner =
                          isLoggedIn && (comment.user.id == _loggedInUserId);

                      return Container(
                        margin: const EdgeInsets.symmetric(vertical: 4),
                        padding: const EdgeInsets.all(8),
                        decoration: BoxDecoration(
                          color: isOwner ? Colors.blue.shade50 : Colors.white,
                          border: Border.all(
                            color: isOwner ? Colors.blue : Colors.grey.shade300,
                          ),
                          borderRadius: BorderRadius.circular(8),
                        ),
                        child: Row(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            CircleAvatar(
                              radius: 20,
                              backgroundImage: comment.user.profilePicture !=
                                      null
                                  ? NetworkImage(
                                      '$baseUrl${comment.user.profilePicture}')
                                  : const AssetImage(
                                      'assets/default_profile.png',
                                    ) as ImageProvider,
                              backgroundColor: Colors.grey.shade200,
                            ),
                            const SizedBox(width: 8),
                            Expanded(
                              child: Column(
                                crossAxisAlignment: CrossAxisAlignment.start,
                                children: [
                                  Row(
                                    mainAxisAlignment:
                                        MainAxisAlignment.spaceBetween,
                                    children: [
                                      Text(
                                        comment.user.userName ?? "Unknown",
                                        style: TextStyle(
                                          fontWeight: FontWeight.bold,
                                          color: isOwner
                                              ? Colors.blue
                                              : Colors.black,
                                        ),
                                      ),
                                      if (isOwner)
                                        Row(
                                          children: [
                                            IconButton(
                                              icon: const Icon(
                                                Icons.edit,
                                                color: Colors.grey,
                                                size: 16,
                                              ),
                                              onPressed: () => _showEditDialog(
                                                context,
                                                comment,
                                              ),
                                            ),
                                            IconButton(
                                              icon: const Icon(
                                                Icons.delete,
                                                color: Colors.red,
                                                size: 16,
                                              ),
                                              onPressed: () =>
                                                  _showDeleteDialog(
                                                context,
                                                comment,
                                              ),
                                            ),
                                          ],
                                        ),
                                    ],
                                  ),
                                  const SizedBox(height: 4),
                                  Text(comment.content),
                                  const SizedBox(height: 4),
                                  Text(
                                    "${comment.createdAt.toLocal()}"
                                        .split(' ')[0],
                                    style: const TextStyle(
                                      fontSize: 12,
                                      color: Colors.grey,
                                    ),
                                  ),
                                ],
                              ),
                            ),
                          ],
                        ),
                      );
                    },
                  ),
          ),
          const Divider(height: 1, color: Colors.grey),

          Padding(
            padding: const EdgeInsets.fromLTRB(8.0, 8.0, 8.0, 50.0),
            child: isLoggedIn
                ? Row(
                    children: [
                      Expanded(
                        child: TextField(
                          controller: _commentController,
                          decoration: const InputDecoration(
                            hintText: "Dodajte komentar...",
                            border: OutlineInputBorder(),
                          ),
                        ),
                      ),
                      const SizedBox(width: 8),
                      ElevatedButton(
                        onPressed: _addComment,
                        child: const Text("Pošalji"),
                      ),
                    ],
                  )
                : const Text(
                    "Morate biti prijavljeni da biste postavili komentar.",
                    style: TextStyle(
                      fontSize: 14,
                      color: Colors.grey,
                    ),
                    textAlign: TextAlign.center,
                  ),
          ),
        ],
      ),
    );
  }
}
