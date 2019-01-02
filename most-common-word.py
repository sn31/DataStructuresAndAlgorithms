from pprint import pprint
from string import punctuation
import string


class Solution:
    def mostCommonWord(self, paragraph, banned):
        punctuations = '''!()-[]{};:'"\,<>./?@#$%^&*_~'''
        word_frequency = {}
        for char in paragraph.lower():
            if char in punctuations:
                paragraph = paragraph.replace(char, " ")

        word_list = list(paragraph.lower().split())

        word_frequency = {x: word_list.count(x)
                          for x in word_list if x not in banned}

        word_frequency_sorted = sorted(
            word_frequency.items(),
            key=lambda kv: kv[1],
            reverse=True)
        return word_frequency_sorted[0][0]
