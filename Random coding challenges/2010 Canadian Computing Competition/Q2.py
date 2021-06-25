class node:
    def __init__(self, letter=None):
        self.left = None
        self.right = None
        self.letter = letter

    def add_right(self, new_node):
        self.right = new_node

    def add_left(self, new_node):
        self.left = new_node
    
    def get_letter(self):
        return self.letter

    def get_left(self):
        return self.left
    
    def get_right(self):
        return self.right
    
    def __repr__(self) -> str:

        left_node = str(self.left)
        right_node = str(self.right)

        return "{0}-\nL:{1}\nR:{2}".format(self.letter, left_node, right_node)

def insert_level_order(root, letter, sequence, i, n):

    if i < n:
        if sequence == "":
            root = node(letter)
        else:
            root = node()

    # insert left
    insert_level_order(root.left, sequence[i:], root.left, 2 * i + 1, n) 

    # traverse to end of sequence
    if sequence[0] == 0:
        nnode.set_left(build_tree(nnode.get_left(), sequence[1:]))
    else:
        nnode.set_right(build_tree(nnode.get_right(), sequence[1:]))
    

def find_letter(nnode, binary_string):
    l = nnode.get_letter()
    if l:
        return l, binary_string

    if binary_string[0] == '0': 
        nnode = nnode.get_left()
    else:
        nnode = nnode.get_right()

    return find_node(nnode, binary_string[1:]) # this is new.... there wasnt a return before

def build_string (root, binary_string):
    if binary_string == '':
        return ''
    letter, remaining = find_letter(root, binary_string)
    
    return letter + build_string(root, remaining)

# Letter Nodes
a = node("A")
b = node("B")
c = node("C")
d = node("D")
e = node("E")

root = node()
L1 = node()
R1 = node()
RR2 = node()

root.add_left(L1)   # 0
root.add_right(R1)  # 1

L1.add_left(a)      # 00
L1.add_right(b)     # 01

R1.add_left(c)      # 10
R1.add_right(RR2)   # 11

RR2.add_left(d)     # 110
RR2.add_right(e)    # 111



'''
k = int(input())
head = node()
for i in range(k):
    input = input().split(' ')
    print(input)
    head.findNode(input[1]).setLetter(input[0])
'''