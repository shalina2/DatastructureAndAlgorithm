LinkedList

An empty linkedlist should be instantiated which includes a head property.
we use insert,include and print.insert takes a value and add it to the node and the value will be the head.
include returns a boolean if the value is within the list.And
print on the other side takes no argument and output all Node values in the Linked List.


This challenge was working on getting the k  value from the linklisted list starting from the end.so i implemented it by having counter,runner and current values.
which the counter and current move together(as long as counter> k) until the end the runner is one step behind.that way we get to the end of the list and we start getting
the kth value.
Big o for space is 0(1) and time is 0(n);

![](https://github.com/shalina2/DatastructureAndAlgorithm/blob/ll_kth_from_end/Asset/Image%20from%20iOS.jpg)
