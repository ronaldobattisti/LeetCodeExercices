def isValid(s):
    validOccur = ('()', '[]', '{}')
    condiction = True
    # print(validOccur)
    if len(s) % 2 != 0:
        return False

    for i in range(int(len(s) / 2)):
        for item in validOccur:
            if item in s:
                s = s.replace(item, "")

    if len(s) > 0:
        return False
    else:
        return True


print(isValid("()"))  # True
print(isValid("()[]{}"))  # True
print(isValid("(]"))  # False
print(isValid('{()}'))  # True
