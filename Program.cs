// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// var x = new MiscA();
// var one = new int[]{1, 1, 2, 3}; //0
// var resultOne = x.ArrayPairs(one);
// Console.WriteLine("1: {0}", resultOne);

// var two = new int[]{1, 1, 2, 2, 3}; //1
// var resultTwo = x.ArrayPairs(two);
// Console.WriteLine("1: {0}", resultTwo);

// var three = new int[]{8, 1, 2, 3, 4, 5, 8, 6, 7, 8, 8, 8, 8}; //3
// var resultThree = x.ArrayPairs(three);
// Console.WriteLine("1: {0}", resultThree);

var x = new ContainsDuplicate();
var y = new int[]{1};
// var y = new int[]{1, 2, 3, 4, 5};
// var y = new int[]{1, 2, 3, 4, 5, 5};
// var y = new int[]{1, 2, 2, 3, 4, 5};
// var y = new int[]{1, 2, 3, 4, 5, 6, 1};
var result = x.ContainsDuplicateSolution(y);


//2 pointer cyclical linked list
// Node head = new Node(1);
//     Node two = new Node(2);
//     head.next = two;
//     Node three = new Node(3);
//     two.next = three;
//     Node four = new Node(4);
//     three.next = four;
//     Node five = new Node(5);
//     four.next = five;
//     // five.next = three;

//     var x = CyclicalLinkedList(head);
//     Console.WriteLine(x);