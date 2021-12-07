class Node:
    right, left, num = None, None, None

    def __init__(self, n):
        self.right = None
        self.left = None 
        self.num = n 

    def getLeft(self):
        return self.Left 

    def getRight(self):
        return self.Right 

    def getNum(self):
        return self.num

    def setLeft(self, n):
        self.left = Node(n)

    def setRight(self, n):
        self.right = Node(n)

def validate(node, lst):
    if (node.getLeft() == None) and (node.getRight() == None):
        return True

    if node.getLeft() is not None:
        if node.getLeft().getNum() > min(lst + [node.getNum()]):
            return False
        else:
            l_val = validate(node.getLeft(), lst + [node.getNum()])
    else:
        l_val = True

    if node.getRight() is not None:
        if node.getRight().getNum() < min(lst + [node.getNum()]):
            return False
        else:
            r_val = validate(node.getRight(), lst + [node.getNum()])
    else:
        r_val = True

    return (l_val and r_val)