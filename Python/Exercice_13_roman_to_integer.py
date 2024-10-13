def convert_to_int(n):
    if n == "I":
        return 1
    elif n == "V":
        return 5
    elif n == "X":
        return 10
    elif n == "L":
        return 50
    elif n == "C":
        return 100
    elif n == "D":
        return 500
    elif n == "M":
        return 1000
    else:
        return 0


def romanToInt(s):
    sum = 0
    for index, n in enumerate(s):
        # print(f"Index: {index} | Number: {n} = {convert_to_int(n)}")
        if index == len(s) - 1:
            sum += convert_to_int(n)
        elif convert_to_int(s[index]) >= convert_to_int(s[index + 1]):
            sum += convert_to_int(n)
        else:
            sum -= convert_to_int(n)
    return sum


print(romanToInt("III"))  # 3
print(romanToInt("LVIII"))  # 58
print(romanToInt("MCMXCIV"))  # 1994


"""
Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
"""
