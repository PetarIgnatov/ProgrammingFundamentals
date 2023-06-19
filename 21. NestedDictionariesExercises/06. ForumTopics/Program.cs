using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._ForumTopics
{
    class Program
    {
        static void Main()
        {

            Dictionary<string, HashSet<string>> result = new Dictionary<string, HashSet<string>>();
            string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();


            while (input[0] != "filter")
            {
                string topic = input[0];
                string[] tag = input[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!result.ContainsKey(topic))
                {
                    result.Add(topic, new HashSet<string>());
                }
                for (int i = 0; i < tag.Length; i++)
                {
                    result[topic].Add(tag[i]);
                }

                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            string[] filteredTags = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var topicData in result)
            {
                string topic = topicData.Key;
                HashSet<string> tags = topicData.Value;


                if (ContainsAllTags(tags, filteredTags))
                {
                    var hashtaggedTags = tags.Select(t => "#" + t);
                    Console.WriteLine($"{topic} | {string.Join(", ", hashtaggedTags)}");
                }
            }
        }
        static bool ContainsAllTags(
            HashSet<string> tags,
            string[] filteredTags)
        {
            foreach (var ft in filteredTags)
            {
                if (!tags.Contains(ft))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
