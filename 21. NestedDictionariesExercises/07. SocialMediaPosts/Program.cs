using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._SocialMediaPosts
{
    class Program
    {
        static Dictionary<string, Dictionary<string, string>> post = new Dictionary<string, Dictionary<string, string>>();
        static Dictionary<string, int> postLikes = new Dictionary<string, int>();
        static Dictionary<string, int> postDislikes = new Dictionary<string, int>();
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            while (input[0] != "drop")
            {
                string command = input[0];
                string postName = input[1];

                switch (command)
                {
                    case "post":
                        {
                            CreatePost(postName);
                            break;
                        }

                    case "like":
                        CreateLike(postName);
                        break;

                    case "dislike":
                        CreateDislike(postName);
                        break;

                    case "comment":
                        string commentatorName = input[2];
                        string commentContent = string.Join(" ", input.Skip(3));
                        CommentPost(postName, commentatorName, commentContent);
                        break;

                }

                input = Console.ReadLine().Split(' ').ToArray();
            }

            foreach (KeyValuePair<string, Dictionary<string, string>> postCommentData in post)
            {
                string postName = postCommentData.Key;
                int likes = postLikes[postName];
                int dislikes = postDislikes[postName];
                Console.WriteLine($"Post: {postName} | Likes: {likes} | Dislikes: {dislikes}");
                Dictionary<string, string> commentsData = postCommentData.Value;

                Console.WriteLine("Comments:");
                if (commentsData.Keys.Count() == 0)
                {
                    Console.WriteLine("None");
                }

                foreach (var comments in commentsData)
                {
                    Console.WriteLine($"*  {comments.Key}: {comments.Value}");
                }
            }

        }


        static void CommentPost(string postName, string commentatorName, string commentContent)
        {
            post[postName].Add(commentatorName, commentContent);
        }

        static void CreateDislike(string postName)
        {
            postDislikes[postName]++;
        }

        static void CreateLike(string postName)
        {
            postLikes[postName]++;
        }

        static void CreatePost(string postName)
        {
            post[postName] = new Dictionary<string, string>();
            postLikes.Add(postName, 0);
            postDislikes.Add(postName, 0);
        }
    }
}