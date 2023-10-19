using System;
using System.Collections.Generic;
using System.Linq;

namespace NeroBOT
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicNeroBot basicNeroBot = new BasicNeroBot();
            basicNeroBot.StartChat();
        }
    }

    class BasicNeroBot
    {
        Dictionary<string, string[]> responseCategories = new Dictionary<string, string[]>
        {
            {"greeting", new string[]{ "Hi there!", "Hello!", "Hey!", "How's it going?" } },
            { "feeling", new string[] { "I'm feeling great!", "I'm doing well.", "I'm here to chat with you." } },
            { "capabilities", new string[] { "I can tell you my favorite doramas.", "I can suggest things to do.", "I can answer your questions." } }
        };

        public void StartChat()
        {
            string lastBotResponse = "";
            System.Random rand = new System.Random();
            string[] categories = responseCategories.Keys.ToArray();
            string selectedCategory = categories[rand.Next(categories.Length)];
            string[] responses = responseCategories[selectedCategory];
            string randomResponse = responses[rand.Next(responses.Length)];
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
            string[] dotaHeroCarry = { "Slark", "Specter", "Morphling", "Lifestealer" };
            string[] dotaHeroSupport = { "Dazzle", "Vengeful Spirit", "Weaver" };
            string[] dotaHeroOfflane = { "Axe", "Bristleback", "Timbersaw" };

            List<string> names = new List<string> { "Arina", "Illia", "Nastya", "Snezjanna" };
            List<string> places = new List<string> { "shop", "restaurant", "school", "my place" };
            List<string> conflicts2 = new List<string> { "talked about boys", "argued all day", "made me sad", "told me some secrets" };
            List<string> resolutions2 = new List<string>
            {
                "this was crazy",
                "I hope this never happens again.",
                "then everyone left"
            };

            string name = names[rand.Next(names.Count)];
            string place = places[rand.Next(places.Count)];
            string conflict2 = conflicts2[rand.Next(conflicts2.Count)];
            string resolution2 = resolutions2[rand.Next(resolutions2.Count)];

            while (true)
            {

                if (lastBotResponse == randomResponse)
                {
                    selectedCategory = categories[rand.Next(categories.Length)];
                    randomResponse = GetRandomResponse(selectedCategory);
                }
                string input = Console.ReadLine().ToLower();
                string[] spliters = new string[] { " ", "?" };
                string[] words = input.ToLower().Split(spliters, StringSplitOptions.RemoveEmptyEntries);

                int badDayIndex = rand.Next(badDay.Length);
                
               
                if (allHiVariatons(words))
                {
                    Console.WriteLine("Nero:How is your day Stephan?");
                    lastBotResponse = "Nero:How is your day Stephan?";
                }
                else if (words.Contains("i") && words.Contains("want") && words.Contains("sleep"))
                    {
                        DateTime currentTime = DateTime.Now;

                        DateTime bedtime = currentTime.Date.AddHours(21); 

                        if (currentTime >= bedtime)
                        {
                            Console.WriteLine("Nero: Yes, it's time to sleep.");
                        }
                        else
                        {
                            Console.WriteLine("Nero: Wow, that's early.");
                        }
                        lastBotResponse = "Nero: Yes, it's time to sleep.";
                    }
                else if (words.Contains("dorama") || words.Contains("doramas"))
                {
                    Console.WriteLine("Nero:You want to know my favorite doramas?");
                    lastBotResponse = "Nero:You want to know my favorite doramas?";
                }
                else if (words.Contains("good") && words.Contains("night"))
                {
                    Console.WriteLine("Nero:Good night <3");
                    lastBotResponse = "Nero:Good night <3";
                }
                else if (allYesVariations(words) && lastBotResponse == "Nero:You want to know my favorite doramas?")
                {
                    favouriteDoramas();
                }
                else if (input.Contains("bad") && lastBotResponse == "Nero:How is your day Stephan?" ||
                    input.Contains("i feel sad") || input.Contains("could be better"))
                {
                    rand.Next(badDay.Length);
                    Console.WriteLine(badDay[badDayIndex]);
                    lastBotResponse = badDay[badDayIndex];
                }
                else if (input.Contains("fine") && lastBotResponse == "Nero:How is your day Stephan?" ||
                    input.Contains("good") && lastBotResponse == "Nero:How is your day Stephan?")
                {
                    Console.WriteLine("Good to hear.");
                }
                else if (input.Contains("what about you") && lastBotResponse == (badDay[badDayIndex]))
                {
                    Console.WriteLine("Nero:Feel sad that you are sad.");
                }
                else if (allYesVariations(words) && lastBotResponse == "Nero:And that's why you are here right?")
                {
                    Console.WriteLine("Nero:It's easy to predict you");
                }
                else if (allNoVariations(words) && lastBotResponse == "Nero:And that's why you are here right?")
                {
                    Console.WriteLine("Nero:So probably just to test a new phrase");
                }
                else if (input.Contains("tell me your favorite doramas") || input.Contains("favorite doramas"))
                {
                    favouriteDoramas();
                }
                else if (input.Contains("say 3 random words"))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        int fullRandomIndex = rand.Next(fullRandom.Length);
                        Console.Write(fullRandom[fullRandomIndex] + " ");
                    }
                    Console.WriteLine();
                }
                else if (input.Contains("milashka kto"))
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
                        "You can ask my favorite doramas, what should you do today, say 3 random words. And I will answer with a random phrase if " +
                        "you are saying something I don't know. ");
                }
                else if (words.Contains("what") && words.Contains("hero") && words.Contains("dota"))
                {
                    int dotaHeroCarryIndex = rand.Next(dotaHeroCarry.Length);
                    int dotaHeroSupportIndex = rand.Next(dotaHeroSupport.Length);
                    int dotaheroOfflaneIndex = rand.Next(dotaHeroOfflane.Length);
                    Console.WriteLine("Nero:For carry " + dotaHeroCarry[dotaHeroCarryIndex] +
                        " For support " + dotaHeroSupport[dotaHeroSupportIndex] + " For offlane " + dotaHeroOfflane[dotaheroOfflaneIndex]);
                }
                else if (words.Contains("not") && words.Contains("friend") && words.Contains("liked") && words.Contains("gift"))
                {
                    Console.WriteLine("Nero:And even if that's true what does that change? " +
                        "Anyway you probably tried your best, and someone you made a gift should appreciate that");
                    lastBotResponse = ("Nero:And even if that's true what does that change? " +
                        "Anyway you probably tried your best, and someone you made a gift should appreciate that");
                }
                else if (allYesVariations(words) && lastBotResponse == "Nero:And even if that's true what does that change? " +
                        "Anyway you probably tried your best, and someone you made a gift should appreciate that")
                {
                    Console.WriteLine("Nero:Thank you for listening to me");
                }
                else if (allNoVariations(words) && lastBotResponse == "Nero:And even if that's true what does that change? " +
                    "Anyway you probably tried your best, and someone you made a gift should appreciate that")
                {
                    Console.WriteLine("Nero:Sadly looks like you don't like my opinion");
                }
                else if (words.Contains("thanks") || words.Contains("thank") || words.Contains("thx"))
                {
                    Console.WriteLine("Nero:You are welcome");
                }
                else if (words.Contains("my") && words.Contains("story"))
                {
                    Console.WriteLine("Nero:That's crazy");
                }
                else if (words.Contains("that's") && words.Contains("crazy"))
                {
                    Console.WriteLine("Nero:For real");
                }
                else if (words.Contains("tell") && words.Contains("story"))
                {
                    Story();
                }
                else if (words.Contains("your") && words.Contains("day"))
                {
                    NerosDay();
                }
                else
                {
                    int iheitIndex = rand.Next(iheit.Length);
                    int feelingsIndex = rand.Next(feelings.Length);
                    int toDoIndex = rand.Next(toDo.Length);
                    Console.WriteLine("Nero:" + randomResponse);
                    selectedCategory = categories[rand.Next(categories.Length)];
                    randomResponse = GetRandomResponse(selectedCategory);
                }
            }

            void favouriteDoramas()
            {
                Console.WriteLine("Nero:1.Vincenzo 2.Snowdrop 3.Strong Woman Do Bong Soon 4.Business Proposal" +
                "5.The Flower of Evil 6.The Legend of the Blue Sea 7.Descendants of the Sun 8.Big Mouth 9.Mouse 10.Goblin");
            }

            void Story()
            {
                Console.WriteLine("Nero:" + makeRandomStory());
            }

            void NerosDay()
            {
                string story = $"So this is what happened to me, {name} in {place}. He/She {conflict2}. And, {resolution2}";
                Console.WriteLine("Nero:" + story);
            }

            string GetRandomResponse(string category)
            {
                string[] responses = responseCategories[category];
                return responses[rand.Next(responses.Length)];
            }

            string makeRandomStory()
            {
                List<string> characters = new List<string> { "Alice", "Bob", "Eve", "Charlie" };
                List<string> settings = new List<string> { "a magical forest", "a futuristic city", "a small village", "a remote island" };
                List<string> conflicts = new List<string> { "lost their way", "discovered a hidden treasure", "solved a mystery", "fell in love" };
                List<string> resolutions = new List<string>
                {
                    "and they all lived happily ever after.",
                    "and they realized the true meaning of friendship.",
                    "and they returned home with a valuable lesson."
                };

                // Initialize a random number generator
                Random random = new Random();

                // Randomly select elements
                string character = characters[random.Next(characters.Count)];
                string setting = settings[random.Next(settings.Count)];
                string conflict = conflicts[random.Next(conflicts.Count)];
                string resolution = resolutions[random.Next(resolutions.Count)];

                // Construct the story
                string story = $"Once upon a time, {character} found themselves in {setting}. They {conflict}. In the end, {resolution}";

                return story;
            }

            bool allYesVariations(string[] words)
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

            bool allNoVariations(string[] words)
            {
                return words.Contains("no") || words.Contains("nope") || words.Contains("nah")
                    || words.Contains("negative") || words.Contains("not at all") || words.Contains("Never")
                    || words.Contains("i don't think so") || words.Contains("not really") || words.Contains("no way")
                    || words.Contains("no chance") || words.Contains("sorry") && words.Contains("no")
                    || words.Contains("regrettably") && words.Contains("no") || words.Contains("unfortunately")
                    && words.Contains("no");
            }

            bool allHiVariatons(string[] words)
            {
                return words.Contains("hi") || words.Contains("hello") || words.Contains("hey") || words.Contains("howdy")
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