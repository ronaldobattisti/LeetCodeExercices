class ListNode:
    def __init__(self, value=0, next=None):
        self.value = value
        self.next = next


class LinkedList:
    def __init__(self):
        self.head = None

    def append(self, value):
        new_node = ListNode(value)
        if not self.head:
            self.head = new_node
            return
        current = self.head
        while current.next:
            current = current.next
        current.next = new_node


"""def mergeTwoLists(list1, list2):
    list1.extend(list2)
    list2 = []
    while len(list1) > 0:
        number = min(list1)
        list1.remove(number)
        list2.append(number)
    return (list2)



print(mergeTwoLists([1, 2, 4], [1, 3, 4]))
print(mergeTwoLists([], []))
print(mergeTwoLists([], [0]))
"""
