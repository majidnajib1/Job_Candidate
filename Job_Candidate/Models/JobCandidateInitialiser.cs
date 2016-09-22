using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Job_Candidate.Models
{
    public class JobCandidateInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<CandidateContext>
    {
       
        protected override void Seed(CandidateContext context)
        {
            
                var candidates = new List<Candidate>
            {
            new Candidate{CandidateID=1,FirstName="Carson",Surname="Alexander",DateOfBirth=DateTime.Parse("1984-04-27"),Address_Line1="87 Alxander Street", Town="Aston",City= "Birmingham", PostCode="B27 0LR", Mobile="07895634128",Email="calexander@hotmial.com", PersonalSatement="A passionate and creative web developer with five years’ experience in a variety of exciting projects. A level head and rational approach to problem solving combined with a passion for innovative and fresh ideas has led to a portfolio of impressive website solutions. Technically competent and industry aware means that each project is undertaken with the most up-to-date and relevant programming foundations available. A strong communicator with the ability to convey ideas clearly with an emphasis on client satisfaction."},
            new Candidate{CandidateID=2,FirstName="Meredith",Surname="Alonso",DateOfBirth=DateTime.Parse("1982-04-19"),Address_Line1="87 Meredith Street", Town="Bethnal Green",City= "London", PostCode="E2 7LP", Mobile="07895634129",Email="malonso@hotmail.com", PersonalSatement="An energetic and imaginative young web developer who is able to work alongside other talented IT professionals in creating websites to the very highest standards. Amanda has a high awareness of industry issues and trends, particularly in regard to accessibility, usability, emerging technologies, and open source CMS. She is an ambitious type who wants to get noticed, and has the drive and massive energy needed to really make a difference to a project. Right now she is looking for an entry level position with an exciting company that wants to attract talented people."},
            new Candidate{CandidateID=3,FirstName="Arturo",Surname="Anand",DateOfBirth=DateTime.Parse("1981-03-21"),Address_Line1="87 Arturo Street", Town="Kings Heath",City= "Birmingham", PostCode="B14 7LP", Mobile="07895634121",Email="aanand@hotmail.com", PersonalSatement="A strong conceptual thinker who has a keen interest in all things related to the Internet. Rachel has the ability and experience needed to design and execute complex software projects for a diverse variety of users. She is committed to having an impact on the future of any company that she works for, and possesses the enthusiasm and commitment to learn and develop her career within a fast paced and growing business. She has a track record of building fluid and dynamic interfaces that are user-friendly, and which positively impact on people’s lives. Right now she is looking for a suitable opportunity that will not only take her career to the next level, but will also allow her to work alongside a very specialised team."},
            new Candidate{CandidateID=4,FirstName="Gytis",Surname="Barzdukas",DateOfBirth=DateTime.Parse("1986-11-21"),Address_Line1="87 Barzdukas Street", Town="Lewishamh",City= "London", PostCode="SE13 8LP", Mobile="07895634122",Email="gbarzdukas@hotmail.com", PersonalSatement="A strong conceptual thinker who has a keen interest in all things related to the Internet. Rachel has the ability and experience needed to design and execute complex software projects for a diverse variety of users. She is committed to having an impact on the future of any company that she works for, and possesses the enthusiasm and commitment to learn and develop her career within a fast paced and growing business. She has a track record of building fluid and dynamic interfaces that are user-friendly, and which positively impact on people’s lives. Right now she is looking for a suitable opportunity that will not only take her career to the next level, but will also allow her to work alongside a very specialised team."},
            new Candidate{CandidateID=5,FirstName="Yan",Surname="Li",DateOfBirth=DateTime.Parse("1984-07-08"),Address_Line1="19 Yanli Street", Town="Aston",City= "Birmingham", PostCode="B27 0LR", Mobile="07895634123",Email="yli@hotmial.com", PersonalSatement="A passionate and creative web developer with five years’ experience in a variety of exciting projects. A level head and rational approach to problem solving combined with a passion for innovative and fresh ideas has led to a portfolio of impressive website solutions. Technically competent and industry aware means that each project is undertaken with the most up-to-date and relevant programming foundations available. A strong communicator with the ability to convey ideas clearly with an emphasis on client satisfaction."},
            new Candidate{CandidateID=6,FirstName="Peggy",Surname="Justice",DateOfBirth=DateTime.Parse("1982-04-19"),Address_Line1="89 Justice Street", Town="Bethnal Green",City= "London", PostCode="E2 7LP", Mobile="07895634124",Email="pjustice@hotmail.com", PersonalSatement="An energetic and imaginative young web developer who is able to work alongside other talented IT professionals in creating websites to the very highest standards. Amanda has a high awareness of industry issues and trends, particularly in regard to accessibility, usability, emerging technologies, and open source CMS. She is an ambitious type who wants to get noticed, and has the drive and massive energy needed to really make a difference to a project. Right now she is looking for an entry level position with an exciting company that wants to attract talented people."},
            new Candidate{CandidateID=7,FirstName="Laura",Surname="Norman",DateOfBirth=DateTime.Parse("1987-03-21"),Address_Line1="87 Norman Street", Town="Kings Heath",City= "Birmingham", PostCode="B14 7LP", Mobile="07895634125",Email="lnorman@hotmail.com", PersonalSatement="A strong conceptual thinker who has a keen interest in all things related to the Internet. Rachel has the ability and experience needed to design and execute complex software projects for a diverse variety of users. She is committed to having an impact on the future of any company that she works for, and possesses the enthusiasm and commitment to learn and develop her career within a fast paced and growing business. She has a track record of building fluid and dynamic interfaces that are user-friendly, and which positively impact on people’s lives. Right now she is looking for a suitable opportunity that will not only take her career to the next level, but will also allow her to work alongside a very specialised team."},
            new Candidate{CandidateID=8,FirstName="Nino",Surname="Olivetto",DateOfBirth=DateTime.Parse("1986-12-17"),Address_Line1="87 Barzdukas Street", Town="Lewishamh",City= "London", PostCode="SE13 8LP", Mobile="07895634126",Email="nolivetto@hotmail.com", PersonalSatement="A strong conceptual thinker who has a keen interest in all things related to the Internet. Rachel has the ability and experience needed to design and execute complex software projects for a diverse variety of users. She is committed to having an impact on the future of any company that she works for, and possesses the enthusiasm and commitment to learn and develop her career within a fast paced and growing business. She has a track record of building fluid and dynamic interfaces that are user-friendly, and which positively impact on people’s lives. Right now she is looking for a suitable opportunity that will not only take her career to the next level, but will also allow her to work alongside a very specialised team."},
            };

                candidates.ForEach(s => context.Candidates.Add(s));

            try
            {
                context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
           

                var qualifications = new List<Qualification>
            {
            new Qualification{CandidateID=1,Title="6 GCSE (including English and Maths)",date="1997",Grade="A-C",},
            new Qualification{CandidateID=1,Title="A LEVEL COMPUTING",date="1999",Grade="C",},
            new Qualification{CandidateID=1,Title="BSC Software Engineering ",date="2003",Grade="2.2 with Hounours",},
            new Qualification{CandidateID=2,Title="6 GCSE (including English and Maths)",date="1997",Grade="A-C",},
            new Qualification{CandidateID=2,Title="A LEVEL COMPUTING",date="1999",Grade="C",},
            new Qualification{CandidateID=2,Title="BSC Software Engineering ",date="2003",Grade="2.2 with Hounours",},
            new Qualification{CandidateID=3,Title="6 GCSE (including English and Maths)",date="1997",Grade="A-C",},
            new Qualification{CandidateID=3,Title="A LEVEL COMPUTING",date="1999",Grade="C",},
            new Qualification{CandidateID=3,Title="BSC Software Engineering ",date="2003",Grade="2.2 with Hounours",},
            new Qualification{CandidateID=4,Title="6 GCSE (including English and Maths)",date="1997",Grade="A-C",},
            new Qualification{CandidateID=4,Title="A LEVEL COMPUTING",date="1999",Grade="C",},
            new Qualification{CandidateID=4,Title="BSC Software Engineering ",date="2003",Grade="2.2 with Hounours",},
            new Qualification{CandidateID=5,Title="6 GCSE (including English and Maths)",date="1997",Grade="A-C",},
            new Qualification{CandidateID=5,Title="A LEVEL COMPUTING",date="1999",Grade="C",},
            new Qualification{CandidateID=5,Title="BSC Software Engineering ",date="2003",Grade="2.2 with Hounours",},
            new Qualification{CandidateID=6,Title="6 GCSE (including English and Maths)",date="1997",Grade="A-C",},
            new Qualification{CandidateID=6,Title="A LEVEL COMPUTING",date="1999",Grade="C",},
            new Qualification{CandidateID=6,Title="BSC Software Engineering ",date="2003",Grade="2.2 with Hounours",},
            new Qualification{CandidateID=7,Title="6 GCSE (including English and Maths)",date="1997",Grade="A-C",},
            new Qualification{CandidateID=7,Title="A LEVEL COMPUTING",date="1999",Grade="C",},
            new Qualification{CandidateID=7,Title="BSC Software Engineering ",date="2003",Grade="2.2 with Hounours",},
            new Qualification{CandidateID=8,Title="6 GCSE (including English and Maths)",date="1997",Grade="A-C",},
            new Qualification{CandidateID=8,Title="A LEVEL COMPUTING",date="1999",Grade="C",},
            new Qualification{CandidateID=8,Title="BSC Software Engineering ",date="2003",Grade="2.2 with Hounours",},
            };
                qualifications.ForEach(s => context.Qualifications.Add(s));
                context.SaveChanges();

                var workexperiences = new List<WorkExperience>
            {
            new WorkExperience{CandidateID=1,JobTitle="Junior Developer",date_Started="07/2005",date_Ended="10/2009",Job_Summary="Responsible for participating in the full life cycle of new website development projects, and for implement and maintaining best practice procedures in all areas of work. Also in charge of writing, developing and managing the content of websites.",},
            new WorkExperience{CandidateID=1,JobTitle="Service Desk Analyst",date_Started="07/2003",date_Ended="06/2005",Job_Summary=" Acting as first point of contact for a variety of incidents and service requests. Answering a range of IT related customer calls, solving or escalating issues as appropriate",},
            new WorkExperience{CandidateID=2,JobTitle="Junior Developer",date_Started="07/2005",date_Ended="10/2009",Job_Summary="Responsible for participating in the full life cycle of new website development projects, and for implement and maintaining best practice procedures in all areas of work. Also in charge of writing, developing and managing the content of websites.",},
            new WorkExperience{CandidateID=2,JobTitle="Service Desk Analyst",date_Started="07/2003",date_Ended="06/2005",Job_Summary=" Acting as first point of contact for a variety of incidents and service requests. Answering a range of IT related customer calls, solving or escalating issues as appropriate",},
            new WorkExperience{CandidateID=3,JobTitle="Junior Developer",date_Started="07/2005",date_Ended="10/2009",Job_Summary="Responsible for participating in the full life cycle of new website development projects, and for implement and maintaining best practice procedures in all areas of work. Also in charge of writing, developing and managing the content of websites.",},
            new WorkExperience{CandidateID=3,JobTitle="Service Desk Analyst",date_Started="07/2003",date_Ended="06/2005",Job_Summary=" Acting as first point of contact for a variety of incidents and service requests. Answering a range of IT related customer calls, solving or escalating issues as appropriate",},
            new WorkExperience{CandidateID=4,JobTitle="Junior Developer",date_Started="07/2005",date_Ended="10/2009",Job_Summary="Responsible for participating in the full life cycle of new website development projects, and for implement and maintaining best practice procedures in all areas of work. Also in charge of writing, developing and managing the content of websites.",},
            new WorkExperience{CandidateID=4,JobTitle="Service Desk Analyst",date_Started="07/2003",date_Ended="06/2005",Job_Summary=" Acting as first point of contact for a variety of incidents and service requests. Answering a range of IT related customer calls, solving or escalating issues as appropriate",},
            new WorkExperience{CandidateID=5,JobTitle="Junior Developer",date_Started="07/2005",date_Ended="10/2009",Job_Summary="Responsible for participating in the full life cycle of new website development projects, and for implement and maintaining best practice procedures in all areas of work. Also in charge of writing, developing and managing the content of websites.",},
            new WorkExperience{CandidateID=5,JobTitle="Service Desk Analyst",date_Started="07/2003",date_Ended="06/2005",Job_Summary=" Acting as first point of contact for a variety of incidents and service requests. Answering a range of IT related customer calls, solving or escalating issues as appropriate",},
            new WorkExperience{CandidateID=6,JobTitle="Junior Developer",date_Started="07/2005",date_Ended="10/2009",Job_Summary="Responsible for participating in the full life cycle of new website development projects, and for implement and maintaining best practice procedures in all areas of work. Also in charge of writing, developing and managing the content of websites.",},
            new WorkExperience{CandidateID=6,JobTitle="Service Desk Analyst",date_Started="07/2003",date_Ended="06/2005",Job_Summary=" Acting as first point of contact for a variety of incidents and service requests. Answering a range of IT related customer calls, solving or escalating issues as appropriate",},
            new WorkExperience{CandidateID=7,JobTitle="Junior Developer",date_Started="07/2005",date_Ended="10/2009",Job_Summary="Responsible for participating in the full life cycle of new website development projects, and for implement and maintaining best practice procedures in all areas of work. Also in charge of writing, developing and managing the content of websites.",},
            new WorkExperience{CandidateID=7,JobTitle="Service Desk Analyst",date_Started="07/2003",date_Ended="06/2005",Job_Summary=" Acting as first point of contact for a variety of incidents and service requests. Answering a range of IT related customer calls, solving or escalating issues as appropriate",},
            new WorkExperience{CandidateID=8,JobTitle="Junior Developer",date_Started="07/2005",date_Ended="10/2009",Job_Summary="Responsible for participating in the full life cycle of new website development projects, and for implement and maintaining best practice procedures in all areas of work. Also in charge of writing, developing and managing the content of websites.",},
            new WorkExperience{CandidateID=8,JobTitle="Service Desk Analyst",date_Started="07/2003",date_Ended="06/2005",Job_Summary=" Acting as first point of contact for a variety of incidents and service requests. Answering a range of IT related customer calls, solving or escalating issues as appropriate",},
            };
                workexperiences.ForEach(s => context.WorkExperiences.Add(s));
                context.SaveChanges();

                var jobs = new List<Job>
            {
                new Job {Job_Title="Junior Developer", Job_Summary="Home Office Digital is undergoing an exciting transformation! We’re looking for talented developers to join our high calibre agile delivery teams. We’re a diverse bunch. Some of us worked at start-ups, others at big corporates. Some people here love Node.js, others Scala and Go (golang). But as long as you’re keen to learn, don’t mind picking up new things and are interested in all aspects of building software systems, you’ll fit right in. You’ll be working across some of the most interesting and complex services government has to offer, in a friendly and supportive environment.You will be working with experts across many different areas and there is huge scope for exchanging ideas and innovations.We’re determined to provide our developers with exceptional support to help them enhance their skills.We offer a generous training budget, regular support from others, and the opportunity to work in a variety of roles and teams.",Salary="£28,280 (National) - £33,229 (National)",},
            };

                jobs.ForEach(s => context.Jobs.Add(s));
                context.SaveChanges();

                var applications = new List<Application>
            {

                new Application {CandidateID=1, JobID=1, DateApplied=DateTime.Parse("10/08/2016") ,},
                new Application {CandidateID=2, JobID=1, DateApplied=DateTime.Parse("11/08/2016") ,},
                new Application {CandidateID=3, JobID=1, DateApplied=DateTime.Parse("12/08/2016") ,},
                new Application {CandidateID=4, JobID=1, DateApplied=DateTime.Parse("13/08/2016") ,},
                new Application {CandidateID=5, JobID=1, DateApplied=DateTime.Parse("14/08/2016") ,},
                new Application {CandidateID=6, JobID=1, DateApplied=DateTime.Parse("15/08/2016") ,},
                new Application {CandidateID=7, JobID=1, DateApplied=DateTime.Parse("16/08/2016") ,},
                new Application {CandidateID=8, JobID=1, DateApplied=DateTime.Parse("17/08/2016") ,},

            };

                applications.ForEach(s => context.Applications.Add(s));
                context.SaveChanges();
            }

           
    
       
}
    }
