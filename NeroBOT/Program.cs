using System;
using System.Linq;

namespace NeroBOT
{
    class Program
    {
        static void Main(string[] args)
        {
            string lastBotResponse = "";

            //Random
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
            string[] dotaHeroCarry = { "Slark", "Specte", "Morphling", "Lifestealer" };
            string[] dotaHeroSupport = { "Dazzle", "Vengeful Spirit", "Weaver" };
            string[] dotaHeroOfflane = {"Axe","Bristleback","Timbersaw"};
            // 

            while (true)
            {
                string input = Console.ReadLine().ToLower();
                string[] spliters = new string[] { " ", "?"};
                string[] words = input.ToLower().Split(spliters, StringSplitOptions.RemoveEmptyEntries);

                int badDayIndex = rand.Next(badDay.Length);

                if (allHiVariatons())
                {
                    Console.WriteLine("Nero:How is your day Stephan?");
                    lastBotResponse = "Nero:How is your day Stephan?";
                }
                //Tokenize
                else if (words.Contains("dorama") || words.Contains("doramas"))
                {
                    Console.WriteLine("Nero:You want to know my favourite doramas?");
                    lastBotResponse = "Nero:You want to know my favourite doramas?";
                }
                else if (allYesVariations() && lastBotResponse == "Nero:You want to know my favourite doramas?") favouriteDoramas();
                //
                else if (input.Contains("bad") && lastBotResponse == "Nero:How is your day Stephan?"
                     || input.Contains("i feel sad"))
                {
                    rand.Next(badDay.Length);
                    Console.WriteLine(badDay[badDayIndex]);
                    lastBotResponse = badDay[badDayIndex];


                }
                else if (input.Contains("fine") && lastBotResponse == "Nero:How is your day Stephan?" || input.Contains("good") && lastBotResponse == "Nero:How is your day Stephan?")
                {
                    Console.WriteLine("Good to hear.");
                }
                else if (input.Contains("what about you") && lastBotResponse == (badDay[badDayIndex]))
                    Console.WriteLine("Nero:Feel sad that u are sad.");
                else if (allYesVariations() && lastBotResponse == "Nero:And that's why you are here right?")
                {
                    Console.WriteLine("Nero:It's easy to predict you");
                }  
                else if (allNoVariations() && lastBotResponse == "Nero:And that's why you are here right?")
                {
                    Console.WriteLine("Nero:So probably just to test new phrase");
                }

                else if (input.Contains("tell me your favourite doramas") || input.Contains("favourite doramas"))
                    favouriteDoramas();
                else if (input.Contains("say 3 random words"))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        int fullRandomIndex = rand.Next(fullRandom.Length);
                        Console.Write(fullRandom[fullRandomIndex] + " ");
                    }
                    Console.WriteLine();
                }
                else if (input.Contains("Milashka kto?"))
                {
                    Console.WriteLine("Nero:Loh");
                }
                else if (words.Contains("what") && words.Contains("do") && words.Contains("today"))
                {
                    int toDoIndex = rand.Next(toDo.Length);
                    Console.WriteLine(toDo[toDoIndex]);
                }
                else if (words.Contains("what") && words.Contains("can") && words.Contains("you") && words.Contains("do"))
                {
                    Console.WriteLine("Nero:I ask you how is your day if you would write me hi." +
                        "You can ask my favourite doramas, what should you do today, say 3 random words. And I will answer with random phrase if " +
                        "you are saying something I don't know. ");
                }
                else if(words.Contains("what") && words.Contains("hero") && words.Contains("dota"))
                {
                    int dotaHeroCarryIndex = rand.Next(dotaHeroCarry.Length);
                    int dotaHeroSupportIndex = rand.Next(dotaHeroSupport.Length);
                    int dotaheroOfflaneIndex = rand.Next(dotaHeroOfflane.Length);
                    Console.WriteLine("Nero:For carry " + dotaHeroCarry[dotaHeroCarryIndex] +
                        " For support " + dotaHeroSupport[dotaHeroSupportIndex] + " For offlane " + dotaHeroOfflane[dotaheroOfflaneIndex]);
                }
                else
                {
                    int iheitIndex = rand.Next(iheit.Length);
                    int feelingsIndex = rand.Next(feelings.Length);
                    int toDoIndex = rand.Next(toDo.Length);
                    Console.WriteLine("Nero:" + iheit[iheitIndex] + " " + feelings[feelingsIndex].ToLower() + " " + toDo[toDoIndex] + " ");
                }
                void favouriteDoramas(){
                    Console.WriteLine("Nero:1.Vincenzo 2.Snowdrop 3.Strong Woman Do Bong Soon 4.Business Proposal" +
    "5.The Flower of Evil 6.The Legend of the Blue Sea 7.Descendants of the Sun 8.Big Mouth 9.Mouse 10.Goblin");
                }
                bool allYesVariations()
                {
                    return words.Contains("yes") || words.Contains("yeah") || words.Contains("y") || words.Contains("yup") 
                        || words.Contains("yea") || words.Contains("uh-huh") || words.Contains("absolutely") 
                        || words.Contains("affirmative") || words.Contains("sure") || words.Contains("you bet") 
                        || words.Contains("roger that") || words.Contains("ok") || words.Contains("okey-dokey")
                        || words.Contains("all right") || words.Contains("course") || words.Contains("indeed")
                        || words.Contains("definitely") || words.Contains("certainly") || words.Contains("without") 
                        && words.Contains("doubt") || words.Contains("No") && words.Contains("doubt") || words.Contains("naturally") 
                        || words.Contains("without") && words.Contains("question") || 
                        words.Contains("by") && words.Contains("all") && words.Contains("means") || words.Contains("indubitably");

                }
                bool allNoVariations()
                {
                        return words.Contains("no") || words.Contains("nope") || words.Contains("nah")
                        || words.Contains("negative") || words.Contains("not at all") || words.Contains("Never")
                        || words.Contains("i don't think so") || words.Contains("not really") || words.Contains("no way")
                        || words.Contains("no chance") || words.Contains("sorry") && words.Contains("no")
                        || words.Contains("regrettably") && words.Contains("no") || words.Contains("unfortunately")
                        && words.Contains("no");
                }
                bool allHiVariatons()
                {
                    return  words.Contains("hi") || words.Contains("hello") || words.Contains("hey") || words.Contains("howdy")
        || words.Contains("hiya") || words.Contains("greetings") || words.Contains("salutations")
        || words.Contains("yo") || words.Contains("hola") || words.Contains("aloha")
        || words.Contains("bonjour") || words.Contains("ciao") || words.Contains("hallo")
        || words.Contains("heya") || words.Contains("namaste") || words.Contains("salaam")
        || words.Contains("shalom") || words.Contains("sup") || words.Contains("wassup")
        || words.Contains("what's up");
                }
            }
        }
    }
}
