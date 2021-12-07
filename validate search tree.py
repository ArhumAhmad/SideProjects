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
        
def helper(node: Node, min, max):
    if node is None:
        return True 
    elif (min is not None and node.getNum() < min) or (max is not None and node.getNum() > max):
        return False
    else:
        return helper(node.getLeft(), min, node.getNum()) and helper(node.getRight(), node.getNum(), max)

def validate(node):
    return helper(node, None, None)