using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PersonalSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly DBContext db;
        public HomeController(DBContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public ActionResult<ResumeData> Index()
        {
            var rd = new ResumeData()
            {
                main = new Main()
                {
                    address = new Address()
                    {
                        city = "Tehran",
                        state = "Tehran, Iran",
                        street = "Khoshi St., Saeedi Hwy",
                        zip = "1371683776"
                    },
                    bio = "A software developer with a passionate enthusiasm for Blockchain Technology and cryptography who loves to code. I also love studying and understanding Programming Languages and how they work under the hood. I also have a keen interest in Machine learning and artificial intelligence stuff. I recently got a chance to lead a team of young and passionate software developers.",
                    contactmessage = "Contact me",
                    email = "hammedmohamadi@gmail.com",
                    image = "profilepic.jpg",
                    name = "Hamed Mohammadi",
                    occupation = "Software Developer",
                    phone = "(+98)939-172-7951",
                    resumedownload = "HMohammadi.pdf",
                    social = new List<Social>()
                    {
                        new Social()
                        {
                            name = "github",
                            className = "fa fa-github",
                            url = "https://github.com/fivil"
                        },
                        new Social()
                        {
                            name = "twitter",
                            url = "https://twitter.com/F_IVI_L",
                            className = "fa fa-twitter"
                        },
                        new Social()
                        {
                            url = "https://www.linkedin.com/in/HammedMohamadi",
                            name = "linkedin",
                            className = "fa fa-linkedin"
                        },
                        new Social()
                        {
                            url="callto://+989391727951",
                            name="Skype",
                            className="fa fa-skype"
                        },
                        new Social()
                        {
                            url="mailto:hammedmohamadi@gmail.com",
                            className="fa fa-envelope",
                            name="envelope"
                        }
                    },
                    website = "http://qmak.ir/"
                },
                portfolio = new Portfolio()
                {
                    projects = new List<Project>()
                    {
                        new Project()
                        {
                            category = "Fully Iranian cryptocurrency teller machine which facilitates the process of buying and selling several different cryptocurrencies",
                            image = "btm.jpg",
                            title = "EXFA- BTM",
                            url = "http://exfa.io/"
                        },
                        new Project()
                        {
                            category="Simple new cryptocurrency based on directed acyclic graph which uses it's very own blockchain, part of my Bachelor's degree project",
                            image="ParsiCoin.JPG",
                            title="Parsi Coin",
                            url="https://github.com/FIVIL/ParsiCoin"
                        },
                        new Project()
                        {
                            category = "Minimum Edit Distance Implementation for my Introduction to Natural Languages processing course.",
                            image = "MED.JPG",
                            title = "Minimum Edit Distance",
                            url = "https://github.com/FIVIL/MED"
                        },
                        new Project()
                        {
                            category = "Fourier Series Visualizer for Engineering Calculus Course",
                            image = "Furier1.JPG",
                            title = "Fourier",
                            url = "https://github.com/FIVIL/Fourier-series"
                        },
                        new Project()
                        {
                            category = "Heart Diseases Diagnosis Expert System for introduction to artificial Intelligence course.",
                            image = "AI1.JPG",
                            title = "HDES",
                            url = "https://github.com/FIVIL/ID3-and-decision-tree"
                        },
                        new Project()
                        {
                            category = "Simple Compiler Lexical Analyser",
                            image = "lexem.JPG",
                            title = "Lexem",
                            url = "https://github.com/FIVIL/Lexeme"
                        },
                        new Project()
                        {
                            category = "Dining Philosopher Problem",
                            image = "NPhilosopher.JPG",
                            title = "Dining Philosopher Problem's answer with p2p network",
                            url = "https://github.com/FIVIL/N-Philasopher"
                        },
                        new Project()
                        {
                            category = "Simple Ball Game",
                            image = "BallGame.JPG",
                            title = "Ball Game",
                            url = "https://github.com/FIVIL/NetWorkProject"
                        },
                        new Project()
                        {
                            category = "Ethereum Based Token which Helps Tracking Ownership of Irainian Authentic Carpets and Provides a Digital Market for Purchesing These Extrovagant ArtPieces.",
                            image = "viracoin.JPG",
                            title = "ViraCoin",
                            url = "http://viracoin2.qmak.ir/"
                        },
                        new Project()
                        {
                            category = "Monitoring and Management Software for High Voltage Switches for Bakhtar Regional Electric Co.",
                            image = "bakhtar.jpg",
                            title = "Switch Manager",
                            url = "http://brec.ir/en"
                        },
                        new Project()
                        {
                            category="a simple implementation of generic smart pointers for C++ programming language based on reference counting. This library can simply address memory leak issues for C++ language.",
                            image="smartpointer.JPG",
                            title="C++ Smart Pointers",
                            url="https://github.com/FIVIL/smart-pointer"
                        }

                    }
                },
                resume = new Resume()
                {
                    education = new List<Education>()
                    {
                        new Education()
                        {
                            degree = "BSc, Software Engineering",
                            school = "K. N. Toosi University of Technology",
                            graduated = "2014–2019",
                            description = "BSc Project Title: Design and Implementation of a New Cryptocurrency(ParsiCoin) Using Directed acyclic graph(DAG) and blockchain technology. Supervisor: Saeed Sedighian Kashi",
                            gpa = "Cumulative GPA:15.16/20 (75.8 %)",
                            courses = @"Java (20/20), Circuit Design Using VHDL (20/20), Operation Systems (19.2/20)
Programming Languages Design (19.1/20), Understanding Assembly Language (18.5/20)
Data Structures (17.5/20), Artificial Intelligence & Expert Systems (17.4/20)"
                        }
                    },
                    work = new List<Work>()
                    {
                        new Work()
                        {
                            company="Raya Exchange",
                            description="Rayex Exchange is a Uniqueu Trading Market for Different Cryptocurrencies, Which Facilitates Leverage Trading.",
                            title="CTO and Core developer",
                             years="September 2019–present",
                             duties="Monitoring Project Progress, Assigning Tasks to Other Project MembersDesigning System Architecture, Developing Back-End Services."
                        }
                    },
                    skillmessage = "",
                    skills = new List<Skill>()
                    {
                        new Skill()
                        {
                            level="90%",
                            name="C#"
                        },
                        new Skill()
                        {
                            level="80%",
                            name="F#"
                        },
                        new Skill()
                        {
                            level="80%",
                            name="Git"
                        },
                        new Skill()
                        {
                             level="75%",
                             name="Java"
                        },
                        new Skill()
                        {
                             level="75%",
                             name="Solidity"
                        },
                        new Skill()
                        {
                             level="75%",
                             name="C++"
                        },
                        new Skill()
                        {
                            level="60%",
                            name="JavaScript"
                        },
                        new Skill()
                        {
                            level="60%",
                             name="Python"
                        },
                        new Skill()
                        {
                            level="50%",
                            name="Go Lang"
                        }
                    },
                    consepts = @"Microservices, Object Oriented Programming, OOP Design Patterns, Functional Programming, Concurrency and Parallelism, Asynchronous programming, Version Control Systems (Git), 
Inversion of Control & Dependency Injection,
                    TCP / IP Socket Programming,
                    SOLID Principles, REST and SOAP Web Services,
                    Event - Driven Programming,
                    Test Driven Development, Continuous Integration & Continuous Delivery,
                    Remote Procedure Call,
                    MVC and MVVM Patterns.",
                    databases = "Microsoft SQL Server, MongoDB, Redis, RavenDB, Elasticsearch.",
                    designLang = "LaTex, HTML5, CSS3, XAML, Markdown.",
                    frameworks = "Anular2+, Blazor, ASP.NET Core, WPF, ML.NET.",
                    libraries = "ReactJS, SignalR, Ef Core, Serilog, XUnit, MOQ, SciPy, NumPy.",
                    tools = "Visual Studio, Docker, Docker Compose, Kubernetes"
                },
                teachingExpreiences = new TeachingExpreiences()
                {
                    expreiences = new List<TeachingExpreience>()
                    {
                        new TeachingExpreience()
                        {
                            course="Compilers",
                            institue="KNTU",
                            instructor="Seyed Hossein Khasteh",
                            title="Teaching assistant",
                            year="Spring 2018"

                        },
                         new TeachingExpreience()
                        {
                            course="Data Structure",
                            institue="KNTU",
                            instructor="Saeed Farzi",
                            title="Teaching assistant",
                            year="Spring 2017"

                        },
                          new TeachingExpreience()
                        {
                            course="Understanding Databases",
                            institue="KNTU",
                            instructor="Saeed Farzi",
                            title="Teaching assistant",
                            year="Fall 2017"

                        },
                           new TeachingExpreience()
                        {
                            course="Understanding Assembly Language",
                            institue="KNTU",
                            instructor="Hoda Roodaki",
                            title="Teaching assistant",
                            year="Spring 2016 -Fall2017"

                        },
                            new TeachingExpreience()
                        {
                            course="Programming with C",
                            institue="KNTU",
                            instructor="Hoda Roodaki",
                            title="Teaching assistant",
                            year="Fall 2015"
                        }
                    },
                    talks = new List<Talk>()
                    {
                        new Talk()
                        {
                            description="Introduction to blockchain for new software students at K. N. Toosi University of Technology.",
                            image="Blockchain.JPG",
                            link="https://www.slideshare.net/HamedMohamadi4/blockchain-101-177784620",
                            subject="Blockchain 101"
                        }
                    }
                }
            };
            return Ok(rd);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]MessageViewModel message)
        {
            message.Id = Guid.NewGuid();
            db.Messages.Add(message);
            await db.SaveChangesAsync();
            return Ok(new { });
        }
    }
}