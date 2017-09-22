# Approach
- Traverse linked list until current.next.data == the data to be deleted.
- Save the node to be deleted in a temporary variable
- Destroy the link to the node to be deleted.
- Set current.next to temporary.next
- Set temporary.next to null