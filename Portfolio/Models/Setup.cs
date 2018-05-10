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

            Project GEICO = new Project("GEICO", "/Media/Tiles/forcePong","TBD");
            GEICO.SkillList.Add("Full-Time");
            GEICO.SkillList.Add(".NET");
            GEICO.SkillList.Add("C#");
            GEICO.SkillList.Add("HTML/CSS");
            GEICO.SkillList.Add("JavaScript");
            GEICO.MediaRefs.Add("https://placehold.it/150x80?text=IMAGE");
            GEICO.MediaRefs.Add("https://placehold.it/150x80?text=IMAGE");
            ProfessionalWork.Add(GEICO);

            Project EF = new Project("EF - Go Ahead Tours", "/Media/Tiles/goAhead", "From September of 2016 to January of 2017, I worked at Education First on the Go Ahead Tours team as an iOS mobile developer.My work included a variety of work on updating and better optimizing the Go Ahead Tours Companion App, which <a href = 'https://itunes.apple.com/us/app/go-ahead-tour-companion/id870744208?mt=8' target = '_blank'> can be found here </a>.I did a lot of front end work, updating the app to its new 2.1 design.Some of the app views I implemented include the itinerary day views, the insurance / travel protection view, the payments view, among a host of other features.The pictures above are all views within the app that I either made from scratch or completely redesigned from the ground up, but not a complete collection of everything I worked on.<br><br><a href = 'http://www.goaheadtours.com/' target = '_blank'> More information about Go Ahead Tours can be found here </a>");
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

            Project VeriPAD = new Project("VeriPAD", "/Media/Tiles/veripad", "Over the summer of 2016 I interned at a start-up company named <a href='http://www.veripad.org' target='_blank'>VeriPAD</a> as a software developer. VeriPAD is a newly formed company that is committed to addressing the epidemic of conterfeit medications in low income communities and countries across the world. My role at the company was designing and implementing computer vision algorithms for an andriod mobile app that will help users identify the validity of a medication based on a chemical test slip that accurately distinguishes properties of the medications chemical makeup.");
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

            #endregion

            #region Web Development Projects Setup
            WebDevelopment = new List<Project>();

            Project Vehicles = new Project("Vehicles Demo", "/Media/Tiles/vehicles", "For this project, I implemented an interactive simulation of braitenburg vehicles. There is one vehicle that is atracted to the light sources, and one that is repeled by them.As they move along the screen, they draw a trail of their path.Over time this can be used to create very interesting abstract art peices, and can be influneced by dragging the lights around with the mouse cursor.The user can also customize alot about the simulation, including the colors of the vehicles and their trails, the brightness of each individual light, as well as even add new lights to the simulation. The user can also increase or decrease the background brightness of the simulation, and toggle off the vehicles an dlight sources so they can focus on viewing the trails as they're created. There isnt much to this project, but it's a very unique and interesting experience to play around with. <a href = 'https://people.rit.edu/~awk9293/CompAesthetics/project2.html' target= '_blank' >It can be viewed here.</a>");
            Vehicles.SkillList.Add("Braitenburg Vehicles");
            Vehicles.SkillList.Add("JavaScript");
            Vehicles.SkillList.Add("Canvas");
            Vehicles.MediaRefs.Add("/Media/Vehicles/vehicles1.png");
            Vehicles.MediaRefs.Add("/Media/Vehicles/vehicles2.png");
            Vehicles.MediaRefs.Add("/Media/Vehicles/vehicles3.png");
            Vehicles.MediaRefs.Add("/Media/Vehicles/vehicles4.png");
            Vehicles.MediaRefs.Add("/Media/Vehicles/vehicles5.png");
            WebDevelopment.Add(Vehicles);

            #endregion

            #region Design Projects Setup
            Design = new List<Project>();

            Project SpiderWeb = new Project("Spider Web", "/Media/Tiles/spiderweb", "This project was done in a team of 7 outside of any classes as a side project. In this game, you play as a spider who uses her web to get around the levels. This game was made using Unity.My role for this game mainly consisted of level design as well as asset management. In addition I also did some programming in C# and implemented a few core environment features for the levels.  However, my involvement mainly consisted of a design role. <a href='https://github.com/LunaLovecraft/IMDHonorsContract-Fall2014' target='_blank'>You can see the github repo here.</a>");
            SpiderWeb.SkillList.Add("Unity");
            SpiderWeb.SkillList.Add("Level Design");
            SpiderWeb.MediaRefs.Add("/Media/Spider Web/spiderweb.mp4");
            SpiderWeb.MediaRefs.Add("/Media/Spider Web/spiderweb.png");
            Design.Add(SpiderWeb);

            #endregion

        }

    }
}