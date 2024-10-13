def palindrome(x):
    index_matrix = []
    x = str(x)
    for item in range(len(x)):
        index_matrix.append(item)
    for item in index_matrix:
        if x[item] != x[len(x) - item - 1]:
            print(
                f"index: {item} | item1: {x[item]} | item2: {x[len(x) - item - 1]} | False")
            return False
    return True


print(palindrome(1223333221))


"""
def palindrome(x):
    index_matrix = []
    condition = False
    x = str(x)
    for item in range(len(x)):
        index_matrix.append(item)
    for item in index_matrix:
        if x[item] == x[len(x) - item - 1]:
            print(
                f"index: {item} | item1: {x[item]} | item2: {x[len(x) - item - 1]} | True")
        else:
            print(
                f"index: {item} | item1: {x[item]} | item2: {x[len(x) - item - 1]} | False")
            return False
    return condition


print(palindrome(12333221))

"""
