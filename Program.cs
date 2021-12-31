// See https://aka.ms/new-console-template for more information
using pa3makeup.database;
using pa3makeup.models;

Console.WriteLine("Hello, World!");
//DeletePost.DropPostTable();
//SavePost.CreatePostTable();

Post myPost = new Post(){Text="Hoops"};
myPost.Save.CreatePost(myPost);



