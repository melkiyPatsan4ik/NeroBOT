using System;
namespace NeroBOT
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] start = { "Nero:Hi, Stephan!", "Nero:Are you here to add new lines?",
                "Nero:I am so happy to meet you again!", "Nero:Creator I was waiting for you!" };
            int index = rand.Next(start.Length);
            Console.WriteLine(start[index]);
            string[] badDay = {"Nero:Someone again made you sad?", "Nero:And that's why you are here right?",
                "Nero:If that because of relationships, think if it's really someone you need? " +
                "Maybe you are missing someone who is interested in you. Just think about that", "Nero:Hope you are gonna be fine" };


            string[] fullRandom = {"I", "Like", "Awesome", "Chill", "Cool", "Crazy", "Cute", "Dope", "Epic",
                "Fantastic", "Fun", "Funky", "Gnarly", "Groovy", "Happy", "Hilarious", "Hip", "Hot", "Insane",
                "Interesting", "Lit", "Lively", "Lovely", "Neat", "Rad", "Random", "Rockin'", "Sick", "Silly",
                "Smooth", "Snazzy", "Super", "Sweet", "Tight", "Trendy", "Trippy", "Unique", "Wavy", "Wild", "Witty",
                "Wonderful", "Yummy", "Games", "Boring", "They", "We", "You", "Movies" };
            string lastBotResponse = "";

            string[] iheit = { "I,", "He,", "She,", "They,", "It," };
            string[] feelings = { "Happy", "Sad", "Angry", "Anxious", "Excited", "Enthusiastic", "Hopeful", "Joyful",
                "Grateful", "Nostalgic", "Optimistic", "Peaceful", "Proud", "Relaxed", "Relieved", "Satisfied",
                "Surprised", "Sympathetic", "Tired", "Worried", "Bored", "Content", "Curious", "Disappointed",
                "Embarrassed", "Empathetic", "Frustrated", "Gloomy", "Irritated", "Lonely", "Miserable", "Pessimistic",
                "Restless", "Skeptical", "Uncomfortable", "Unhappy", "Vulnerable", "Zealous", "Astonished", "Ecstatic",
                "Flustered", "Overwhelmed", "Sorrowful", "Blissful", "Euphoric", "Overjoyed", "Panicked", "Stressed",
                "Confident", "Enraged", "Horrified", "Hysterical", "Indignant", "Insecure", "Melancholy", "Numb",
                "Offended", "Rejected", "Shocked", "Shy", "Suspicious", "Threatened", "Yearning", "Admiration",
                "Affection", "Amusement", "Annoyance", "Anticipation", "Awe", "Confusion", "Disgust", "Distrust",
                "Envy", "Enthusiasm", "Excitement", "Fear", "Frustration", "Gratitude", "Grief", "Happiness", "Hatred",
                "Hope", "Hunger", "Impatience", "Indifference", "Interest", "Jealousy", "Loneliness", "Love", "Lust",
                "Pleasure", "Pride", "Rage", "Regret", "Remorse", "Resentment", "Sadness", "Satisfaction", "Shame",
                "Surprise", "Suspense", "Sympathy", "Terror", "Trust", "Wonder", "Worry", "Apathy", "Contempt", "Delight",
                "Despair", "Disappointment", "Empathy", "Excitement", "Fulfillment", "Hate", "Incredulity", "Inspiration",
                "Liking", "Misery", "Nostalgia", "Outrage", "Relief", "Skepticism", "Yearning", "Zest", "Anguish", "Bliss",
                "Comfort", "Compassion", "Eagerness", "Elation", "Gladness", "Heartbreak", "Jubilation", "Longing",
                "Nervousness", "Optimism", "Rapture", "Sadomasochism", "Serenity", "Skepticism", "Sorrow", "Spite",
                "Vexation" };
            string[] toDo = {"games", "movies", "sport", "talking", "cooking", "reading", "traveling", "dancing",
                "drawing", "writing", "singing", "painting", "coding", "swimming", "biking", "hiking", "camping",
                "skiing", "photography", "gardening", "yoga", "meditation", "shopping", "fishing", "playing an instrument",
                "learning a new language", "volunteering", "listening to music", "watching TV", "surfing the internet" };
            {

            }
            while (true)
            {
                int badDayIndex = rand.Next(badDay.Length);
                string input = Console.ReadLine();
                if (input.Contains("Hello") || input.Contains("Hi"))
                {
                    Console.WriteLine("Nero:How is your day Stephan?");
                    lastBotResponse = "Nero:How is your day Stephan?";
                }
                else if (input.Contains("Bad") && lastBotResponse == "Nero:How is your day Stephan?"
                     || input.Contains("I feel sad"))
                {
                    rand.Next(badDay.Length);
                    Console.WriteLine(badDay[badDayIndex]);
                    lastBotResponse = badDay[badDayIndex];


                }
                else if (input.Contains("What about you") && lastBotResponse == (badDay[badDayIndex]))
                    Console.WriteLine("Nero:Feel sad that u are sad.");
                else if (input.Contains("Yes") && lastBotResponse == "Nero:And that's why you are here right?")
                {
                    Console.WriteLine("Nero:It's easy to predict you");
                }

                else if (input.Contains("Tell me your favourite doramas") || input.Contains("favourite doramas"))
                    Console.WriteLine("Nero:1.Vincenzo 2.Snowdrop 3.Strong Woman Do Bong Soon 4.Business Proposal" +
                        "5.The Flower of Evil 6.The Legend of the Blue Sea 7.Descendants of the Sun 8.Big Mouth 9.Mouse 10.Goblin");
                else if (input.Contains("Say 3 random words"))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        int fullRandomIndex = rand.Next(fullRandom.Length);
                        Console.Write(fullRandom[fullRandomIndex] + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    int iheitIndex = rand.Next(iheit.Length);
                    int feelingsIndex = rand.Next(feelings.Length);
                    int toDoIndex = rand.Next(toDo.Length);
                    Console.WriteLine(iheit[iheitIndex] + " " + feelings[feelingsIndex] + " " + toDo[toDoIndex] + " ");
                }


            }
        }
    }
}
