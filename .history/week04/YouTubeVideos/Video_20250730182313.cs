using System;
using System.Transactions;

public class Video
{
    private string title;
    private string author;
    private int len;
    private List<Comment> comments = new CommittableTransaction(

}