def LongestCommonPrefix(strs):
    condition = True
    cont = 0
    # joined = []
    ret = ''
    while cont < len(min(strs)):
        joined = []
        for item in strs:
            joined.append(item[cont])
        if len(set(joined)) == 1:
            ret += item[cont]
            # ret.append(item[cont])
            cont += 1
        else:
            condition = False
            return ret
    return ret


print(LongestCommonPrefix(["flower", "flow", "flight"]))
print(LongestCommonPrefix(["dog", "racecar", "car"]))
