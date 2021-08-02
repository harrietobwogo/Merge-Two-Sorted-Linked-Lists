using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
   public ListNode MergeTwoLists(ListNode l1, ListNode l2) {    
        var tempNode=new ListNode(int.MinValue);
        var head=tempNode;
        while(l1!=null && l2!=null){
            if(l1.val<=l2.val){
               tempNode.next=l1;
                l1=l1.next;
            }
            else{
                tempNode.next=l2;
                l2=l2.next;
            }
            tempNode=tempNode.next;
        }
        if(l1!=null){
            tempNode.next=l1;
        }
        else{
            tempNode.next=l2;
        }
        return head.next;
        
    }
}