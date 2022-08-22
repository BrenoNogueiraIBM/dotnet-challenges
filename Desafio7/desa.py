import math
import os
import random
import re
import sys

#
# Complete the 'caesarCipher' function below.
#
# The function is expected to return a STRING.
# The function accepts following parameters:
#  1. STRING s
#  2. INTEGER k
#


def caesarCipher(s, k):
    # Write your code here
    e = ""
    alfabeto = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
                'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ]
    ALFA = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
            'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z']

    cypher = ""
    z = 0
    for s1 in s:
        if not s1 in alfabeto and not s1 in ALFA:
            cypher += s1
            continue 

        for j, s2 in enumerate(alfabeto):
            z = j + k
            if s2 == s1:
                cypher += alfabeto[z % 26]
                break
            elif ALFA[j] == s1:
                cypher += ALFA[z % 26]
                break

    return cypher


if __name__ == '__main__':
    # fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input().strip())

    s = input()

    k = int(input().strip())

    result = caesarCipher(s, k)

    print(result)

    # fptr.write(result + '\n')

    # fptr.close()
