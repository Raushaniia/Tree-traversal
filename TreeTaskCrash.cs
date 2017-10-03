//a. DepthFirstPreOrderStack(TreeNode root)

void preOrder(Node root) {
    Stack<Node> stack = new Stack<Node>();
    stack.push(root);
    while(!stack.empty()){
        Node curruntNode = stack.peek();
        stack.pop();
        System.out.print(curruntNode.data + " ");
         if(curruntNode.right!= null){
            stack.push(curruntNode.right);
        }
        if(curruntNode.left != null){
            stack.push(curruntNode.left);
        }
    }
}

//b. DepthFirstPreOrderRecursive(TreeNode root)

void preOrder(Node root) {
    if(root != null){
        System.out.print(root.data + " ");
        preOrder(root.left);
        preOrder(root.right);
    }
}

//c. DepthFirstInOrderStack(TreeNode root)

void preOrder(Node root) {
    Stack<Node> stack = new Stack<Node>();
    stack.push(root);
    Node node = root;
    while(!stack.empty()){
        if(node != null){
            stack.push(node);
            node = node.left;
        }
        else{
            node = stack.pop();
            System.out.print(node.data + " ");
            node = node.right;
        }
    }
}

//d. DepthFirstInOrderRecursive(TreeNode root)

void preOrder(Node root) {
    if(root != null){
        preOrder(root.left);
        System.out.print(root.data + " ");
        preOrder(root.right);
    }    
}

//e. DepthFirstPostOrderStack(TreeNode root)

void preOrder(Node root) {
    Stack<Node> stack = new Stack<Node>();
    Node lastNodevisited = null;
    while(stack != null){
        if (root != null){
            stack.push(root);
            root = root.left;
        }
        else{
            Node peekNode = stack.peek();
            if (peekNode.right != null && lastNodevisited != peekNode.right)
                root = peekNode.right;
            else{
                System.out.print(peekNode.data + " ");
                lastNodevisited = stack.pop();
            }
        }
    }
}


//f. DepthFirstPostOrderRecursive(TreeNode root)

void preOrder(Node root) {
    if (root != null){
       preOrder(root.left);
       preOrder(root.right);
       System.out.print(root.data + " ");
    }
}

//g. BreadthFirstSearchQueue(TreeNode root)

void preOrder(Node root) {
    ArrayDeque<Node> queue=new ArrayDeque<Node>();
    queue.add(root);
    while(queue != null){
        root = queue.pop();
        System.out.print(root.data + " ");
        if(root.left != null){
            queue.add(root.left);
        }
        if(root.right != null){
            queue.add(root.right);
        }
    }
}



