
class Solution:
    def addStrings(self, num1, num2):

        num1New = num1
        num2New = num2
        if len(num1) < len(num2):
            num1New = ("0" * (len(num2) - len(num1))) + num1New
        else:
            num2New = ("0" * (len(num1) - len(num2))) + num2New
        res = ""
        end = max(len(num1), len(num2))
        carry = 0
        for n in reversed(range(end)):
            tempRes = (int(num1New[n])+int(num2New[n])+carry)
            if tempRes >= 10:
                carry = 1
                res = chr(48+tempRes-10) + res
            else:
                carry = 0
                res = chr(48+tempRes) + res
        if carry == 1:
            res = "1" + res
        return res
