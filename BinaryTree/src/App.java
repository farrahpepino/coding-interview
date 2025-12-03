public class App {
 
    public static void main(String[] args) throws Exception {
    }

    class BinaryTree{
        Node root;

        public BinaryTree(int key) {
            this.root = new Node(key);
        }

        public BinaryTree() {
            this.root = null;
        }

        
    }

    class Node{
        int key;
    
        Node leftChild;
        Node rightChild;
    
        Node(int key){
            this.key = key;
            this.leftChild = this.rightChild = null;
        }
        
       
    }
}


