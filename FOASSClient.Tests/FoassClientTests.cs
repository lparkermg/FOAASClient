﻿using System.Threading;
using System.Threading.Tasks;
using FOAASClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FOASSClient.Tests
{
    [TestClass]
    public class FoassClientTests
    {
        private readonly IFoaasClient _foaasClient;

        public FoassClientTests()
        {
            _foaasClient = new FoaasClient();
        }

        [TestMethod]
        public async Task FuckingOffShouldWork()
        {
            var res = await _foaasClient.Off("Joker", "Batman");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck off, Joker.", res.Message);
            Assert.AreEqual("- Batman", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingYouShouldWork()
        {
            var res = await _foaasClient.You("Harpo", "Groucho");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck you, Harpo.", res.Message);
            Assert.AreEqual("- Groucho", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingThatShouldWork()
        {
            var res = await _foaasClient.That("Moses");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck that.", res.Message);
            Assert.AreEqual("- Moses", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingThisShouldWork()
        {
            var res = await _foaasClient.This("Jesus H. Christ");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck this.", res.Message);
            Assert.AreEqual("- Jesus H. Christ", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingEverythingShouldWork()
        {
            var res = await _foaasClient.Everything("John F. Kennedy");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck everything.", res.Message);
            Assert.AreEqual("- John F. Kennedy", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingEveryoneShouldWork()
        {
            var res = await _foaasClient.Everyone("Bumblebee");
            Assert.IsNotNull(res);
            Assert.AreEqual("Everyone can go and fuck off.", res.Message);
            Assert.AreEqual("- Bumblebee", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingDonutShouldWork()
        {
            var res = await _foaasClient.Donut("Hillary", "Bill");
            Assert.IsNotNull(res);
            Assert.AreEqual("Hillary, go and take a flying fuck at a rolling donut.", res.Message);
            Assert.AreEqual("- Bill", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingShakespeareShouldWork()
        {
            var res = await _foaasClient.Shakespeare("Wolverine", "Professor X");
            Assert.IsNotNull(res);
            Assert.AreEqual(
                "Wolverine, Thou clay-brained guts, thou knotty-pated fool, thou whoreson obscene greasy tallow-catch!",
                res.Message);
            Assert.AreEqual("- Professor X", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingLinusShouldWork()
        {
            var res = await _foaasClient.Linus("Lucy", "Charlie Brown");
            Assert.IsNotNull(res);
            Assert.AreEqual(
                "Lucy, there aren't enough swear-words in the English language, so now I'll have to call you perkeleen vittupää just to express my disgust and frustration with this crap.",
                res.Message);
            Assert.AreEqual("- Charlie Brown", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingKingShouldWork()
        {
            var res = await _foaasClient.King("Lucy", "Ricki");
            Assert.IsNotNull(res);
            Assert.AreEqual(
                "Oh fuck off, just really fuck off you total dickface. Christ Lucy, you are fucking thick.", res.Message);
            Assert.AreEqual("- Ricki", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingPinkShouldWork()
        {
            var res = await _foaasClient.Pink("Simba");
            Assert.IsNotNull(res);
            Assert.AreEqual("Well, fuck me pink.", res.Message);
            Assert.AreEqual("- Simba", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingLifeShouldWork()
        {
            var res = await _foaasClient.Life("Gandhi");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck my life.", res.Message);
            Assert.AreEqual("- Gandhi", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingChainsawShouldWork()
        {
            var res = await _foaasClient.Chainsaw("Jim", "Dr. McCoy");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck me gently with a chainsaw, Jim. Do I look like Mother Teresa?", res.Message);
            Assert.AreEqual("- Dr. McCoy", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingOutsideShouldWork()
        {
            var res = await _foaasClient.Outside("BigBrother", "TheWorld");
            Assert.IsNotNull(res);
            Assert.AreEqual("BigBrother, why don't you go outside and play hide-and-go-fuck-yourself?", res.Message);
            Assert.AreEqual("- TheWorld", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingThingShouldWork()
        {
            var res = await _foaasClient.Thing("pineapples", "Chris");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck pineapples.", res.Message);
            Assert.AreEqual("- Chris", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingThanksShouldWork()
        {
            var res = await _foaasClient.Thanks("Abraham Lincoln");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck you very much.", res.Message);
            Assert.AreEqual("- Abraham Lincoln", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingFlyingShouldWork()
        {
            var res = await _foaasClient.Flying("Barack Obama");
            Assert.IsNotNull(res);
            Assert.AreEqual("I don't give a flying fuck.", res.Message);
            Assert.AreEqual("- Barack Obama", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingFascinatingShouldWork()
        {
            var res = await _foaasClient.Fascinating("Marie Curie");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fascinating story, in what chapter do you shut the fuck up?", res.Message);
            Assert.AreEqual("- Marie Curie", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingMadisonShouldWork()
        {
            var res = await _foaasClient.Madison("Doctor", "Rose");
            Assert.IsNotNull(res);
            Assert.AreEqual(
                "What you've just said is one of the most insanely idiotic things I have ever heard, Doctor. At no point in your rambling, incoherent response were you even close to anything that could be considered a rational thought. Everyone in this room is now dumber for having listened to it. I award you no points Doctor, and may God have mercy on your soul.",
                res.Message);
            Assert.AreEqual("- Rose", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingCoolShouldWork()
        {
            var res = await _foaasClient.Cool("Luke");
            Assert.IsNotNull(res);
            Assert.AreEqual("Cool story, bro.", res.Message);
            Assert.AreEqual("- Luke", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingFieldShouldWork()
        {
            var res = await _foaasClient.Field("Yo Momma", "John", "A Book, Chapter 2.");
            Assert.IsNotNull(res);
            Assert.AreEqual(
                "And Yo Momma said unto John, 'Verily, cast thine eyes upon the field in which I grow my fucks', and John gave witness unto the field, and saw that it was barren.",
                res.Message);
            Assert.AreEqual("- A Book, Chapter 2.", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingNuggetShouldWork()
        {
            var res = await _foaasClient.Nugget("Bill", "Ben");
            Assert.IsNotNull(res);
            Assert.AreEqual("Well Bill, aren't you a shining example of a rancid fuck-nugget.", res.Message);
            Assert.AreEqual("- Ben", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingYodaShouldWork()
        {
            var res = await _foaasClient.Yoda("Luke", "Yoda");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck off, you must, Luke.", res.Message);
            Assert.AreEqual("- Yoda", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingBallmerShouldWork()
        {
            var res = await _foaasClient.Ballmer("Someone", "Something", "Ballmer");
            Assert.IsNotNull(res);
            Assert.AreEqual(
                "Fucking Someone is a fucking pussy. I'm going to fucking bury that guy, I have done it before, and I will do it again. I'm going to fucking kill Something.",
                res.Message);
            Assert.AreEqual("- Ballmer", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingWhatShouldWork()
        {
            var res = await _foaasClient.What("Frank");
            Assert.IsNotNull(res);
            Assert.AreEqual("What the fuck‽", res.Message);
            Assert.AreEqual("- Frank", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingBecauseShouldWork()
        {
            var res = await _foaasClient.Because("Tina");
            Assert.IsNotNull(res);
            Assert.AreEqual("Why? Because fuck you, that's why.", res.Message);
            Assert.AreEqual("- Tina", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingCaniuseShouldWork()
        {
            var res = await _foaasClient.Caniuse("Hammer", "Bob the Builder");
            Assert.IsNotNull(res);
            Assert.AreEqual("Can you use Hammer? Fuck no!", res.Message);
            Assert.AreEqual("- Bob the Builder", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingByeShouldWork()
        {
            var res = await _foaasClient.Bye("Claire");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuckity bye!", res.Message);
            Assert.AreEqual("- Claire", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingDiabetesShouldWork()
        {
            var res = await _foaasClient.Diabetes("Charley");
            Assert.IsNotNull(res);
            Assert.AreEqual("I'd love to stop and chat to you but I'd rather have type 2 diabetes.", res.Message);
            Assert.AreEqual("- Charley", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingBusShouldWork()
        {
            var res = await _foaasClient.Bus("Laura", "James");
            Assert.IsNotNull(res);
            Assert.AreEqual("Christ on a bendy-bus, Laura, don't be such a fucking faff-arse.", res.Message);
            Assert.AreEqual("- James", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingXmasShouldWork()
        {
            var res = await _foaasClient.Xmas("Clive", "Your Mother");
            Assert.IsNotNull(res);
            Assert.AreEqual("Merry Fucking Christmas, Clive.", res.Message);
            Assert.AreEqual("- Your Mother", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingBdayShouldWork()
        {
            var res = await _foaasClient.Bday("Grant", "The Crew");
            Assert.IsNotNull(res);
            Assert.AreEqual("Happy Fucking Birthday, Grant.", res.Message);
            Assert.AreEqual("- The Crew", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingAwesomeShouldWork()
        {
            var res = await _foaasClient.Awesome("Macklemore");
            Assert.IsNotNull(res);
            Assert.AreEqual("This is Fucking Awesome.", res.Message);
            Assert.AreEqual("- Macklemore", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingTuckerShouldWork()
        {
            var res = await _foaasClient.Tucker("Malcolm Tucker");
            Assert.IsNotNull(res);
            Assert.AreEqual("Come the fuck in or fuck the fuck off.", res.Message);
            Assert.AreEqual("- Malcolm Tucker", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingBucketShouldWork()
        {
            var res = await _foaasClient.Bucket("Richard Dickson");
            Assert.IsNotNull(res);
            Assert.AreEqual("Please choke on a bucket of cocks.", res.Message);
            Assert.AreEqual("- Richard Dickson", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingFamilyShouldWork()
        {
            var res = await _foaasClient.Family("Jezza");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck you, your whole family, your pets, and your feces.", res.Message);
            Assert.AreEqual("- Jezza", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingShutupShouldWork()
        {
            var res = await _foaasClient.Shutup("Jeff", "Gary");
            Assert.IsNotNull(res);
            Assert.AreEqual("Jeff, shut the fuck up.", res.Message);
            Assert.AreEqual("- Gary", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingZaynShouldWork()
        {
            var res = await _foaasClient.Zayn("Zayn");
            Assert.IsNotNull(res);
            Assert.AreEqual("Ask me if I give a motherfuck ?!!", res.Message);
            Assert.AreEqual("- Zayn", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingKeepCalmShouldWork()
        {
            var res = await _foaasClient.KeepCalm("Cry me a fast flowing river", "Dustin Timberland");
            Assert.IsNotNull(res);
            Assert.AreEqual("Keep the fuck calm and Cry me a fast flowing river!", res.Message);
            Assert.AreEqual("- Dustin Timberland", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingDoSomethingShouldWork()
        {
            var res = await _foaasClient.DoSomething("Get", "Washing", "Mother");
            Assert.IsNotNull(res);
            Assert.AreEqual("Get the fucking Washing!", res.Message);
            Assert.AreEqual("- Mother", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingMorninShouldWork()
        {
            var res = await _foaasClient.Mornin("Monday");
            Assert.IsNotNull(res);
            Assert.AreEqual("Happy fuckin' mornin'!", res.Message);
            Assert.AreEqual("- Monday", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingThumbsShouldWork()
        {
            var res = await _foaasClient.Thumbs("This Guy", "Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Who has two thumbs and doesn't give a fuck? This Guy.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingRetardShouldWork()
        {
            var res = await _foaasClient.Retard("Josh");
            Assert.IsNotNull(res);
            Assert.AreEqual("You Fucktard!", res.Message);
            Assert.AreEqual("- Josh", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingGreedShouldWork()
        {
            var res = await _foaasClient.Greed("Cash", "BigCat");
            Assert.IsNotNull(res);
            Assert.AreEqual(
                "The point is, ladies and gentleman, that cash -- for lack of a better word -- is good. Cash is right. Cash works. Cash clarifies, cuts through, and captures the essence of the evolutionary spirit. Cash, in all of its forms -- Cash for life, for money, for love, knowledge -- has marked the upward surge of mankind.",
                res.Message);
            Assert.AreEqual("- BigCat", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingAnywayShouldWork()
        {
            var res = await _foaasClient.Anyway("Microsoft", "Someone Else");
            Assert.IsNotNull(res);
            Assert.AreEqual("Who the fuck are you anyway, Microsoft, why are you stirring up so much trouble, and, who pays you?", res.Message);
            Assert.AreEqual("- Someone Else", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingBackShouldWork()
        {
            var res = await _foaasClient.Back("You", "Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("You, back the fuck off.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingBagShouldWork()
        {
            var res = await _foaasClient.Bag("Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Eat a bag of fucking dicks.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingBlackadderShouldWork()
        {
            var res = await _foaasClient.Blackadder("You", "Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("You, your head is as empty as a eunuch’s underpants. Fuck off!", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingBravoMikeShouldWork()
        {
            var res = await _foaasClient.BravoMike("Frank", "Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Bravo mike, Frank.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingCocksplatShouldWork()
        {
            var res = await _foaasClient.Cocksplat("Frank", "Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck off Frank, you worthless cocksplat", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingDaltonShouldWork()
        {
            var res = await _foaasClient.Dalton("You", "Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("You: A fucking problem solving super-hero.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingDeraadtShouldWork()
        {
            var res = await _foaasClient.Deraadt("Frank", "Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Frank you are being the usual slimy hypocritical asshole... You may have had value ten years ago, but people will see that you don't anymore.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingGolfFoxtrotYankeeShouldWork()
        {
            var res = await _foaasClient.GolfFoxtrotYankee("Frank", "Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Golf foxtrot yankee, Frank.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingGiveShouldWork()
        {
            var res = await _foaasClient.Give("Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("I give zero fucks.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingHorseShouldWork()
        {
            var res = await _foaasClient.Horse("Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck you and the horse you rode in on.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingFuckOffShouldWork()
        {
            var res = await _foaasClient.FuckingOff("Frank", "Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fucking fuck off, Frank.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingKeepShouldWork()
        {
            var res = await _foaasClient.Keep("Frank", "Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Frank: Fuck off. And when you get there, fuck off from there too. Then fuck off some more. Keep fucking off until you get back here. Then fuck off again.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingLookShouldWork()
        {
            var res = await _foaasClient.Look("Frank", "Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Frank, do I look like I give a fuck?", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingLookingShouldWork()
        {
            var res = await _foaasClient.Looking("Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Looking for a fuck to give.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingMaybeShouldWork()
        {
            var res = await _foaasClient.Maybe("Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Maybe. Maybe not. Maybe fuck yourself.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingMeShouldWork()
        {
            var res = await _foaasClient.Me("Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck me.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingNoShouldWork()
        {
            var res = await _foaasClient.No("Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("No fucks given.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingOffWithShouldWork()
        {
            var res = await _foaasClient.OffWith("that", "Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck off with that", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingParticularShouldWork()
        {
            var res = await _foaasClient.Particular("Sausage", "Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck this Sausage in particular.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingProblemShouldWork()
        {
            var res = await _foaasClient.Problem("Frank", "Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("What the fuck is your problem Frank?", res.Message);
            Assert.AreEqual("- Me",  res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingPulpShouldWork()
        {
            var res = await _foaasClient.Pulp("Japanese", "Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Japanese, motherfucker, do you speak it?", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingRidiculousShouldWork()
        {
            var res = await _foaasClient.Ridiculous("Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("That's fucking ridiculous", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task ReadingTheFuckingManualShouldWork()
        {
            var res = await _foaasClient.ReadTheManual("Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Read the fucking manual!", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingSakeShouldWork()
        {
            var res = await _foaasClient.Sake("Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("For Fuck's sake!", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingShitShouldWork()
        {
            var res = await _foaasClient.Shit("Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck this shit!", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingSingleShouldWork()
        {
            var res = await _foaasClient.Single("Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Not a single fuck was given.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingThinkShouldWork()
        {
            var res = await _foaasClient.Think("Frank", "Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Frank, you think I give a fuck?", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingThinkingShouldWork()
        {
            var res = await _foaasClient.Thinking("Frank","Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Frank, what the fuck where you actually thinking?", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingTooShouldWork()
        {
            var res = await _foaasClient.Too("Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Thanks, fuck you too.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingZeroShouldWork()
        {
            var res = await _foaasClient.Zero("Me");
            Assert.IsNotNull(res);
            Assert.AreEqual("Zero, thats the number of fucks I give.", res.Message);
            Assert.AreEqual("- Me", res.Subtitle);
        }
    }
}
