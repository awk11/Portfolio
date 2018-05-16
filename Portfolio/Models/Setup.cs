using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Portfolio.Models;

namespace Portfolio
{
    public static class Setup
    {
        public static List<Project> ProfessionalWork { get; }
        public static List<Project> AppDevelopment { get; }
        public static List<Project> WebDevelopment { get; }
        public static List<Project> Design { get; }

        public static void Initialize()
        {

        }

        static Setup()
        {
            #region Professional Work Projects Setup
            ProfessionalWork = new List<Project>();

            Project GEICO = new Project("GEICO", "/Media/Tiles/geico", "I began work at GEICO in June of 2017 as part of their rotational entry level hiring program they call the Technology Development Program, with my first assignment being to the Claims Department. Since joining, my responsibilities have primarily focused around the development of a .NET internal web application, which acts as a portal that can house web based automation tools used throughout the Claims department at the company. I am the lead on this project and have acted as the primary developer from conception to production. In working on this project, some of the things I've done are: </p><ul><li>Implement a fully functioning login system that works with an internal network</li><li>Create a custom logging system</li><li> Work with security and encrypting sensitive data that passes through the application</li><li>Write and maintain in depth documentation</li><li>Work with a variety of teams across the Claims department as well as the company at large to both get the application up and running and on requested features and tools</li><li>Design a code architecture such that new features can be easily implemented by others in the future who are not familiar with .NET or MVC frameworks</li></ul><p>Some of the technologies this project involved using include the .NET MVC framework, working with Active Directory, connecting to external SQL Databases, etc.<br /><br />I am also the primary developer supporting a legacy VB Windows Forms application used by the SIU (Special Investigative Unit) to manage and track claim cases. Unfortunately I can't show any pictures of my work as they are internal applications.<br /><br />Outside of my primary responsibilities, I have gone through extensive training courses in topics ranging from .NET to DevOps and Agile. I started at GEICO with the title of Programmer Analyst 2 and have since been promoted to Programmer Analyst 3.");
            GEICO.SkillList.Add("Full-Time");
            GEICO.SkillList.Add(".NET");
            GEICO.SkillList.Add("C#");
            GEICO.SkillList.Add("HTML/CSS");
            GEICO.SkillList.Add("JavaScript");
            GEICO.SkillList.Add("Visual Studio");
            GEICO.SkillList.Add("JIRA");
            GEICO.SkillList.Add("Team Foundation Server");
            GEICO.MediaRefs.Add("/Media/GEICO/Geico.jpg");
            ProfessionalWork.Add(GEICO);

            Project EF = new Project("EF - Go Ahead Tours", "/Media/Tiles/goAhead", "From September of 2016 to January of 2017, I worked at Education First on the Go Ahead Tours team as an iOS mobile developer. My responsibilities included updating and better optimizing the Go Ahead Tours Companion App, which <a href = 'https://itunes.apple.com/us/app/go-ahead-tour-companion/id870744208?mt=8' target = '_blank'> can be found here</a>. I did a lot of front end work, updating the app to its new 2.1 design. Some of the app views I implemented include the itinerary day views, the insurance/travel protection view, the payments view, among a host of other features. These pictures are all views within the app that I either made from scratch or completely recreated from the ground up working with a design team, but not a complete collection of everything I worked on.<br><br><a href = 'http://www.goaheadtours.com/' target = '_blank'>More information about Go Ahead Tours can be found here.</a>");
            EF.SkillList.Add("Internship");
            EF.SkillList.Add("iOS Development");
            EF.SkillList.Add("Swift");
            EF.SkillList.Add("Objective-C");
            EF.MediaRefs.Add("/Media/EF/gat1.png");
            EF.MediaRefs.Add("/Media/EF/gat2.png");
            EF.MediaRefs.Add("/Media/EF/gat3.png");
            EF.MediaRefs.Add("/Media/EF/gat4.png");
            EF.MediaRefs.Add("/Media/EF/gat5.png");
            EF.MediaRefs.Add("/Media/EF/gat6.png");
            EF.MediaRefs.Add("/Media/EF/gat7.png");
            EF.MediaRefs.Add("/Media/EF/gat8.png");
            EF.MediaRefs.Add("/Media/EF/gat9.png");
            ProfessionalWork.Add(EF);

            Project VeriPAD = new Project("VeriPAD", "/Media/Tiles/veripad", "Over the summer of 2016 I interned at a start-up company named <a href='http://www.veripad.org' target='_blank'>VeriPAD</a> as a software developer. VeriPAD is a newly formed company that is committed to addressing the epidemic of counterfeit medications in low income communities and countries across the world. My role at the company was designing and implementing computer vision algorithms for an Andriod mobile app that will help users identify the validity of a medication based on a chemical test slip that accurately distinguishes properties of the medication's chemical makeup.");
            VeriPAD.SkillList.Add("Internship");
            VeriPAD.SkillList.Add("Computer Vision (OpenCV)");
            VeriPAD.SkillList.Add("Android");
            VeriPAD.SkillList.Add("Java");
            VeriPAD.MediaRefs.Add("/Media/VeriPAD/veripadlogo.png");
            ProfessionalWork.Add(VeriPAD);

            #endregion

            #region App Development Projects Setup
            AppDevelopment = new List<Project>();

            Project BatGame = new Project("Bat Game", "/Media/Tiles/batgame", "For this project I worked on a small team to make a top down adventure game, which ultimately just got named, Bat Game because, well, you play as a bat. The game is primarily stealth focused, as the player has no real attack other than to use a shriek to stun an enemy bat, but that doesnt last long.The goal is for the player to navigate hrough the caves and find their way out using stealth and pateince while not getting caught and killed by the other, bigger bats. The game was made in XNA, and was done as a class project. I worked on it as the lead designer and AI programmer, as well as worked on a level editor and the level implementation and other various tasks.For the enemies movement AI I implemented A* path finding.You can check out the<a href='https://github.com/SolidSoup/BatGame' target='_blank'> github repo here</a>. But to run it you'd need visual studio and XNA nstalled on your machine. Same goes for the level editor.");
            BatGame.SkillList.Add("Game AI");
            BatGame.SkillList.Add("Game Development");
            BatGame.SkillList.Add("C#");
            BatGame.SkillList.Add("XNA");
            BatGame.MediaRefs.Add("/Media/Bat Game/batgame.mp4");
            BatGame.MediaRefs.Add("/Media/Bat Game/batgame.png");
            AppDevelopment.Add(BatGame);

            Project AiWarzone = new Project("AI Warzone Tech Demo", "/Media/Tiles/aiwarzone", "This was the final project for a class in the fall of 2014. It consisted of building a unity scene in which agents would interact with each other dynamically in some way.I chose to make a battlefield scene which demonstrates some advanced steering behaviors.Specifically, I implemented flocking, pursuing, evading, wandering using perlin noise, obstacle avoidance, as well as containment. <br><br> Simply put, the scene is set up with 2 teams, humans and skeletons, each team is set up into 3 squads of 4. Each squad flocks together and they seek out enemies as a flock when they see them.They will then eventually collide with each other on individual entity bases, in which one of them will then 'die' and be respawned at the teams spawn point.<br><br>The <a href='https://github.com/awk11/AI-War-zone-demo' target='_blank'> github repo is here </a>.To control the camera you can just use the left or right arrow keys to switch between following different squads, or just go until you hit the free cam, in which case you move using wasd and the mouse.");
            AiWarzone.SkillList.Add("Game/Behavioral AI");
            AiWarzone.SkillList.Add("Unity");
            AiWarzone.SkillList.Add("C#");
            AiWarzone.MediaRefs.Add("/Media/AI Warzone/AIWarzoneTechDemo.mp4");
            AiWarzone.MediaRefs.Add("/Media/AI Warzone/aiwarzone.png");
            AppDevelopment.Add(AiWarzone);

            Project CellsvVirus = new Project("Cells v Virus", "/Media/Tiles/cvv", "This was a class assignment in the fall of 2014. The goal of this project was to create a simulation in which one type of entity would pursue and assimilate another type of entity until all entities on the screen were of the same type. Similar to a humans and zombie type of scenario. However, for this project, I decided to change the theme to cells and viruses. In this simulation, entities use pursuit, evasion, and obstacle avoidance. The cells simply wander, or run away when they are near a virus, while the virus' seek the cells, or just wander when none are nearby.");
            CellsvVirus.SkillList.Add("Game/Behavioral AI");
            CellsvVirus.SkillList.Add("Java/Processing API");
            CellsvVirus.MediaRefs.Add("/Media/Cells v Virus/CVV.mp4");
            CellsvVirus.MediaRefs.Add("/Media/Cells v Virus/cvv.png");
            AppDevelopment.Add(CellsvVirus);

            Project Asteroids = new Project("Asteroids", "/Media/Tiles/asteroids", "This was an in class assignment made in java's processing API. For this project, I decided to take a new spin on asteroids by making it Halo themed (the famous video game franchise). This required the use of game physics as well as animation programming. The game has music as well as menus, and is basically a customized asteroids clone.");
            Asteroids.SkillList.Add("Game Development");
            Asteroids.SkillList.Add("Java/Processing API");
            Asteroids.MediaRefs.Add("https://www.youtube.com/embed/53WRD4HFsus");
            Asteroids.MediaRefs.Add("/Media/Asteroids/asteroids.png");
            AppDevelopment.Add(Asteroids);

            Project DuelingGrounds = new Project("Dueling Grounds", "/Media/Tiles/duelingGrounds", "Dueling Grounds is an arena based fighting game for 2 players, where players fight in rounds with one hit KO's until one player wins 10 rounds and is declared the winner Each player can pick from three different character's all with unique playstyles. For this project, I worked in a small team, but my work included desgining and implementing all of the characters, acting as the team leader, designing the arena, and a majority of the gameplay programming.");
            DuelingGrounds.SkillList.Add("Game Development");
            DuelingGrounds.SkillList.Add("Game Design");
            DuelingGrounds.SkillList.Add("C#");
            DuelingGrounds.SkillList.Add("XNA");
            DuelingGrounds.MediaRefs.Add("/Media/Dueling Grounds/duelingGrounds.png");
            DuelingGrounds.MediaRefs.Add("/Media/Dueling Grounds/duelingGrounds2.png");
            DuelingGrounds.MediaRefs.Add("/Media/Dueling Grounds/duelingGrounds3.png");
            DuelingGrounds.MediaRefs.Add("/Media/Dueling Grounds/duelingGrounds4.png");
            DuelingGrounds.MediaRefs.Add("/Media/Dueling Grounds/duelingGrounds5.png");
            DuelingGrounds.MediaRefs.Add("/Media/Dueling Grounds/duelingGrounds6.png");
            DuelingGrounds.MediaRefs.Add("/Media/Dueling Grounds/duelingGrounds7.png");
            DuelingGrounds.MediaRefs.Add("/Media/Dueling Grounds/duelingGrounds8.png");
            AppDevelopment.Add(DuelingGrounds);

            Project ForcePong = new Project("Force Pong", "/Media/Tiles/forcePong", "For this project, I was assigned as part of a small team, to make a game using OpengGL. So ultimately we decided to make a simple pong game, but with the twist of being able to control the ball while its moving across the screen. Both players can move it in both directions and it's actually a lot of fun.For this project, I worked on implementing the controls as well as all of the physics programming and collisions. The github can be viewed<a href='https://github.com/Raccoon-Studios/Main-Game' target='_blank'>here</a>");
            ForcePong.SkillList.Add("Graphics Programming");
            ForcePong.SkillList.Add("OpenGL");
            ForcePong.SkillList.Add("C++");
            ForcePong.MediaRefs.Add("/Media/Force Pong/forcePong.mp4");
            ForcePong.MediaRefs.Add("/Media/Force Pong/forcePong.png");
            AppDevelopment.Add(ForcePong);

            Project Lively = new Project("Lively", "/Media/Tiles/lively", "This project is an IOS app I created with one other person for the IOS App Challenge 2016, which was hosted by Apple at my university.For the hackathon, we had a weekend to build a multi - platform app.So what we eventually created by the end of the weekend was Lively. Lively is an app that allows you to create photo collections based on vacations, life events, or whatever your heart desires, and tag a ocation for the event so you never forget where it was.In addition you can also write short blurbs about each picture you add to a collection, similar to how people write on the backs of actual photographs.Lively has both IOS and tvOS functionality, and transfers data over icloud for the user to use both asynchronously. For the app, my contributions were primarily all of the front end programming and design work for the ios version of the app. I did a lot of the contraints and storyboard work, as well as designed the logo and look of the app. I also implemented the location tagging feature.This was my first experience using swift in any capacity.The github repo can be viewed <a href='https://github.com/SMaraia/Lively' target='_blank'>here</a>. Note that all of my commits for this are labeled as Apple because I didnt own a mac and had to borrow one from Apple.");
            Lively.SkillList.Add("iOS Development");
            Lively.SkillList.Add("Mobile Design");
            Lively.SkillList.Add("Swift");
            Lively.MediaRefs.Add("/Media/Lively/lively1.png");
            Lively.MediaRefs.Add("/Media/Lively/lively2.png");
            Lively.MediaRefs.Add("/Media/Lively/lively3.png");
            Lively.MediaRefs.Add("/Media/Lively/lively4.png");
            Lively.MediaRefs.Add("/Media/Lively/lively5.png");
            Lively.MediaRefs.Add("/Media/Lively/lively6.png");
            AppDevelopment.Add(Lively);

            #endregion

            #region Web Development Projects Setup
            WebDevelopment = new List<Project>();

            Project CGOLNode = new Project("C-GOL", "/Media/Tiles/c-gol", "For this project, I created and designed a simple website that hosts an interactive Conway’s Game of Life simulator. Users can customize the rules, paint or erase cells within the simulation at any time while it's paused, and even save the creations they make to an account they made. This site has a fully functional login system, and was built using javascript, jquery, html, css, express.js, MongoDB, and Redis. It can be seen at <a href='http://c-gol.herokuapp.com' target='_blank'>c-gol.herokuapp.com</a>");
            CGOLNode.SkillList.Add("Game Theory (CS Topic)");
            CGOLNode.SkillList.Add("JavaScript");
            CGOLNode.SkillList.Add("HTML/CSS");
            CGOLNode.SkillList.Add("Canvas");
            CGOLNode.SkillList.Add("Express/Node js");
            CGOLNode.SkillList.Add("MongoDB");
            CGOLNode.SkillList.Add("Heroku");
            CGOLNode.SkillList.Add("Model View Controller Architecture");
            CGOLNode.MediaRefs.Add("/Media/Game of Life (Node)/c-gol1.png");
            CGOLNode.MediaRefs.Add("/Media/Game of Life (Node)/c-gol2.png");
            CGOLNode.MediaRefs.Add("/Media/Game of Life (Node)/c-gol3.png");
            CGOLNode.MediaRefs.Add("/Media/Game of Life (Node)/c-gol4.png");
            WebDevelopment.Add(CGOLNode);

            Project GOLNet = new Project("A-GOL", "/Media/Tiles/a-gol", "In an effort to demonstate my .NET skillset, I spent a couple of days taking the C-GOL project I had completed in college using Node.js and converting it to be .NET based. From the user perspective there isn't much difference between the two versions, but looking at how things are organized in the back end there are quite a few. One of the bigger differences for example is how saved simulations are stored and organized. In this .NET version, simulations are tied to account database entries, rather than simulation saves being saved in a seperate table with a reference to the account it's tied to.<br /><br />The codebase for this version is available on my github <a href='https://github.com/awk11/A-GOL'>here</a>. A live verion of the application can be seen at <a href='https://a-gol.azurewebsites.net'>a-gol.azurewebsites.net</a>");
            GOLNet.SkillList.Add(".NET");
            GOLNet.SkillList.Add("C#");
            GOLNet.SkillList.Add("JavaScript");
            GOLNet.SkillList.Add("HTML/CSS");
            GOLNet.SkillList.Add("Canvas");
            GOLNet.SkillList.Add("Game Theory (CS Topic)");
            GOLNet.SkillList.Add("Azure");
            GOLNet.SkillList.Add("Model View Controller Architecture");
            GOLNet.MediaRefs.Add("/Media/Game of Life (NET)/a-gol1.png");
            GOLNet.MediaRefs.Add("/Media/Game of Life (NET)/a-gol2.png");
            GOLNet.MediaRefs.Add("/Media/Game of Life (NET)/a-gol3.png");
            GOLNet.MediaRefs.Add("/Media/Game of Life (NET)/a-gol4.png");
            WebDevelopment.Add(GOLNet);

            Project Portfolio = new Project("Portfolio", "/Media/Tiles/portfolio", "This website is set up using a .NET MVC framework. Setting this up took a few days, using my background knowledge in C#, .NET, javascript, and HTML5/CSS3. I took inspiration for the design from some of the samples on <a href='https://www.w3schools.com' target='_blank'>w3schools.com</a>, but for the most part made it my own, incorporating different elements from a few of the themes they have made available for open use. As for the back end, I chose to set it up using .NET so I could have a dynamic layout in regards to the experience section. Each of these projects is set up as an object on the back end, which is then grabbed and displayed dynamically. The code is available on my Github <a href='https://github.com/awk11/Portfolio' target='_blank'>here</a>.");
            Portfolio.SkillList.Add(".NET");
            Portfolio.SkillList.Add("C#");
            Portfolio.SkillList.Add("HTML/CSS");
            Portfolio.SkillList.Add("JavaScript");
            Portfolio.SkillList.Add("Azure");
            Portfolio.SkillList.Add("Model View Controller Architecture");
            Portfolio.MediaRefs.Add("/Media/Portfolio/portfolio1.png");
            WebDevelopment.Add(Portfolio);

            Project Vehicles = new Project("Vehicles Demo", "/Media/Tiles/vehicles", "For this project, I implemented an interactive simulation of Braitenburg vehicles. There is one vehicle that is attracted to the light sources, and one that is repelled by them. As they move along the screen, they draw a trail of their path. Over time this can be used to create very interesting abstract art pieces, and can be influenced by dragging the lights around with the mouse cursor. The user can also customize a lot about the simulation, including the colors of the vehicles and their trails, the brightness of each individual light, as well as even add new lights to the simulation. The user can also increase or decrease the background brightness of the simulation, and toggle off the vehicles and light sources so they can focus on viewing the trails as they're created. There isn't much to this project, but it's a very unique and interesting experience to play around with. <a href = 'https://people.rit.edu/~awk9293/CompAesthetics/project2.html' target= '_blank' >It can be viewed here.</a>");
            Vehicles.SkillList.Add("Braitenburg Vehicles");
            Vehicles.SkillList.Add("JavaScript");
            Vehicles.SkillList.Add("Canvas");
            Vehicles.MediaRefs.Add("/Media/Vehicles/vehicles1.png");
            Vehicles.MediaRefs.Add("/Media/Vehicles/vehicles2.png");
            Vehicles.MediaRefs.Add("/Media/Vehicles/vehicles3.png");
            Vehicles.MediaRefs.Add("/Media/Vehicles/vehicles4.png");
            Vehicles.MediaRefs.Add("/Media/Vehicles/vehicles5.png");
            WebDevelopment.Add(Vehicles);

            Project Audio = new Project("Audio Visualizer", "/Media/Tiles/audioVisualizer", "This project is a visualizer for audio that is played through the page. I can't include too many songs because of copyright, but basically what it does is takes data from the audio that's playing, and alters the image on the screen based on that. There are a lot of different options for how you can customize the experience, which are accessed by hitting the square in the top right corner.<a href='https://people.rit.edu/~awk9293/330/audioproject.html' target='_blank'> You can play around with it yourself here.</a>");
            Audio.SkillList.Add("Web Audio API");
            Audio.SkillList.Add("JavaScript");
            Audio.SkillList.Add("Canvas");
            Audio.MediaRefs.Add("/Media/Audio/audioVisualizer1.png");
            Audio.MediaRefs.Add("/Media/Audio/audioVisualizer2.png");
            WebDevelopment.Add(Audio);

            #endregion

            #region Design Projects Setup
            Design = new List<Project>();

            Project SpiderWeb = new Project("Spider Web", "/Media/Tiles/spiderweb", "This project was done in a team of 7 outside of any classes as a side project. In this game, you play as a spider who uses her web to get around the levels. This game was made using Unity.My role for this game mainly consisted of level design as well as asset management. In addition I also did some programming in C# and implemented a few core environment features for the levels.  However, my involvement mainly consisted of a design role. <a href='https://github.com/LunaLovecraft/IMDHonorsContract-Fall2014' target='_blank'>You can see the github repo here.</a>");
            SpiderWeb.SkillList.Add("Unity");
            SpiderWeb.SkillList.Add("Level Design");
            SpiderWeb.MediaRefs.Add("/Media/Spider Web/spiderweb.mp4");
            SpiderWeb.MediaRefs.Add("/Media/Spider Web/spiderweb.png");
            Design.Add(SpiderWeb);

            Project BlueVoid = new Project("Blue Void", "/Media/Tiles/bluevoid", "This project was a class assignment in which I was tasked with creating, designing, and prototyping the design of a mobile game application. For this project, I created moodboards, sketched and planned out the user interface of the app, as well as doing considerable on paper testing of my designs.");
            BlueVoid.SkillList.Add("");
            BlueVoid.MediaRefs.Add("/Media/Blue Void/bluevoid.png");
            BlueVoid.MediaRefs.Add("/Media/Blue Void/bluevoid2.png");
            BlueVoid.MediaRefs.Add("/Media/Blue Void/bluevoid3.png");
            BlueVoid.MediaRefs.Add("/Media/Blue Void/bluevoid4.png");
            BlueVoid.MediaRefs.Add("/Media/Blue Void/bluevoid5.png");
            BlueVoid.MediaRefs.Add("/Media/Blue Void/bluevoid6.png");
            BlueVoid.MediaRefs.Add("/Media/Blue Void/bluevoid7.png");
            BlueVoid.MediaRefs.Add("/Media/Blue Void/bluevoid8.png");
            BlueVoid.MediaRefs.Add("/Media/Blue Void/bluevoid9.png");
            Design.Add(BlueVoid);

            Project LawnGnomeRage = new Project("Lawn Gnome Rage", "/Media/Tiles/lawnGnomeRage", "Lawn Gnome Rage is an analog board game for 2-6 players I made as part of a small team, with the objective of controlling the entire neighborhood by controlling all of the control points, or capitols. It's like RISK in that aspect, however there are many differences in the way the game is played.In Lawn Gnome Rage, you have different units, strong gnomes, defense gnomes and stealth gnomes, all of which have different purposes and uses for a variety of situations.When two gnomes from posing teams battle eachother, the players use a d & d style battle system to determine a winner(as in players role appropriate dice and add any buffs or weaknesses). Each turn the player draw's a gnome card with a type of their choosing (strong, defense, or stealth), and when a player has both a body and a head for the type of gnome they want to build, they can build the gnome and place it at one of their capitols. <br><br> My involvement in this project consisted of helping to design and implement rules, as well as design the game board.");
            LawnGnomeRage.SkillList.Add("");
            LawnGnomeRage.MediaRefs.Add("/Media/Lawn Gnome Rage/lawnGnomeRage0.png");
            LawnGnomeRage.MediaRefs.Add("/Media/Lawn Gnome Rage/lawnGnomeRage1.png");
            LawnGnomeRage.MediaRefs.Add("/Media/Lawn Gnome Rage/lawnGnomeRage2.png");
            LawnGnomeRage.MediaRefs.Add("/Media/Lawn Gnome Rage/lawnGnomeRage3.png");
            LawnGnomeRage.MediaRefs.Add("/Media/Lawn Gnome Rage/lawnGnomeRage4.png");
            LawnGnomeRage.MediaRefs.Add("/Media/Lawn Gnome Rage/lawnGnomeRage5.png");
            LawnGnomeRage.MediaRefs.Add("/Media/Lawn Gnome Rage/lawnGnomeRage6.png");
            Design.Add(LawnGnomeRage);

            #endregion

        }

    }
}