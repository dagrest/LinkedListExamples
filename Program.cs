namespace LinkedList_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList_Examples");
            Node n5 = new Node{Value = "5", Next = null};
            Node n4 = new Node{Value = "4", Next = n5};
            Node n3 = new Node{Value = "3", Next = n4};
            Node n2 = new Node{Value = "2", Next = n3};
            Node n1 = new Node{Value = "1", Next = n2};
            Node n0 = new Node{Value = "0", Next = n1};

            n0.printList();
            Console.WriteLine("LinkedList_Example Finished");

            Node n = n0.reverseList();
            n.printList();
        }
    }

    class Node
    {
        public string Value {get; set;}
        public Node? Next {get; set;}

        public void printList()
        {
            printList(this);
            Console.WriteLine();
        }

        public void printList(Node node)
        {
            Console.Write("{0} ", node.Value);
            if(node.Next != null){
                printList(node.Next);
            }
        }

        public Node reverseList()
        {

            Node? prev = null;
            Node? curr = this;

            while(curr != null){
                Node temp = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = temp;
            }

            return prev;
        }
    }
}