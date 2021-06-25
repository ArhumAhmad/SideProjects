class node:
    def __init__(self, letter=None, identifier=None):
        self.left = None
        self.right = None
        self.letter = letter
        self.identifier = identifier

    def add_right(self, child):
        self.right = child

    def add_left(self, child):
        self.left = child
    
    def get_letter(self):
        return self.letter

    def get_left(self):
        return self.left
    
    def get_right(self):
        return self.right
    
    def __repr__(self) -> str:

        left_node = str(self.left)
        right_node = str(self.right)

        return "{0}:{1} L[{2}] R[{3}]".format(self.identifier, self.letter, left_node, right_node)

def find_letter(nnode, sequence):
    l = nnode.get_letter()
    if l:
        return l, sequence

    if sequence[0] == '0': 
        nnode = nnode.get_left()
    else:
        nnode = nnode.get_right()

    return find_letter(nnode, sequence[1:])

def insert_node(parent, sequence, c):
    if sequence == '':
        return

    if len(sequence) == 1:
        child = node(letter=c)
    else:
        child = node(identifier="^")
    
    if sequence[0] == '0':
        if parent.get_left() is None:
            parent.add_left(child)
        else:
            child = parent.get_left()
    else:
        if parent.get_right() is None:
            parent.add_right(child)
        else:
            child = parent.get_right()

    insert_node(child, sequence[1:], c)

def build_string (root, sequence):
    if sequence == '':
        return ''
    letter, remaining = find_letter(root, sequence)
    
    return letter + build_string(root, remaining)


'''k = int(input())
root = node()
for i in range(k):
    s = input().split()
    insert_node(root, s[1], s[0])
print(root)
s = input()
print(build_string(root, s))'''

k = 5
root = node(identifier="*")
lst = ["A 00", "B 01", "C 10", "D 110", "E 111"]
for i in range(k):
    s = lst[i].split()
    insert_node(root, s[1], s[0])
s = "00000101111"
print(build_string(root, s))
