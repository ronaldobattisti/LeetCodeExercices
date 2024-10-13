def twoSum(nums, target):
    for index, item in enumerate(nums):
        for index, item in enumerate(nums):
            nums_buf = nums
            nums_buf.pop(index)
            print(nums)
            print(index)
            print(nums_buf)
            for item2 in nums:
                if (item + item2 == target):
                    return [nums.index(item), nums.index(item2)]
             


        
        '''print(f"String nums: {nums}")
        print(f"Item: {item}")
        print(f"Index: {index}")
        print(f"nums_buf: {nums_buf}")'''


twoSum([2, 7, 11, 15], 9)
             