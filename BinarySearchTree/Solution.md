# Solution
- Check if root is null, if so set root as new node(data).
- Check if current node.data == data, if so return (No Duplicates).
- Check if data is greater than or less than node.data.
- If the relevant child is null then add the new node(data) at that position, else Add(child node, data)