// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using test_c__1;
using static System.Net.Mime.MediaTypeNames;

string? a ;
List<StudentModel> student = new List<StudentModel> ();
InitStu(student);
List<TeacherModel> teacher = new List<TeacherModel>();
InitTeacher(teacher);
List<TermModel> term = new List<TermModel>();  
Console.WriteLine("Welcome to Language School");
loopmain:
Console.WriteLine("Menu : ");
Console.WriteLine("1. Teacher Panel(Type num 1 and enter)");
Console.WriteLine("2. Student Panel(Type num 2 and enter)");
Console.WriteLine("3. Term Panel(Type num 3 and enter)");
Console.WriteLine("4. Exit(Type num 4 and enter)");

a = CheckNullableMenu();


Console.Clear();
    switch (a)
    {
        case "1":
        {

        loopmenu:
            Console.Clear();
            Console.WriteLine("Teacher Menu : ");
            Console.WriteLine("1. Teacher registration(Type num 1 and enter)");
            Console.WriteLine("2. List of Teacher(Type num 2 and enter)");
            Console.WriteLine("3. Edit Teacher Info(Type num 3 and enter)");
            Console.WriteLine("4. Remove Teacher(Type num 4 and enter)");
            Console.WriteLine("5. Exit to menu(Type num 5 and enter)");

        loopdeff:
            a = CheckNullableMenu();

            Console.Clear();
            switch (a)
            {
                case "1":
                    {
                        TeacherModel createTeacher = new TeacherModel();
                        Console.WriteLine("Enter First Name : ");
                        createTeacher.FName = CheckNullableList();

                        Console.WriteLine("Enter Last Name : ");
                        createTeacher.LName = CheckNullableList();

                        Console.WriteLine("Enter Teacher Code : ");
                        createTeacher.TCode = Convert.ToInt32(CheckNullableList());

                        Console.WriteLine("Enter National Code : ");
                        createTeacher.NCode = Convert.ToInt32(CheckNullableList());
                        
                        teacher.Add(new TeacherModel
                        {
                            FName = createTeacher.FName,
                            LName = createTeacher.LName,
                            TCode = createTeacher.TCode,
                            NCode = createTeacher.NCode,
                        });
                        Console.WriteLine("Save Success");
                        AwaitGoToMenu();
                        goto loopmenu;

                        break;
                    }
                case "2":
                    {
                        if (teacher.Count > 0)
                        {
                            Console.WriteLine("Teacher List : ");
                            ShowListTeacher(teacher);
                            AwaitGoToMenu();
                            goto loopmenu;
                        }
                        else
                        {
                            Console.WriteLine("Can not found any teacher");
                            AwaitGoToMenu();
                            goto loopmenu;
                        }
                        break;
                    }
                case "3":
                    {

                        if (teacher.Count > 0)
                        {

                            Console.WriteLine("Enter teacher national code : ");
                            var Code = Convert.ToInt32(CheckNullableList());
                            foreach (var item in teacher)
                            {

                                if (item.NCode == Code)
                                {

                                    TeacherModel editTeacher = new TeacherModel();
                                    Console.WriteLine("Enter New First Name : ");
                                    editTeacher.FName = CheckNullableList();

                                    Console.WriteLine("Enter Last Name : ");
                                    editTeacher.LName = CheckNullableList();


                                    editTeacher.NCode = item.NCode;

                                    Console.WriteLine("Enter teacher code : ");
                                    editTeacher.TCode = Convert.ToInt32(CheckNullableList());

                                    teacher[teacher.IndexOf(item)].FName = editTeacher.FName;
                                    teacher[teacher.IndexOf(item)].LName = editTeacher.LName;
                                    teacher[teacher.IndexOf(item)].NCode = editTeacher.NCode;
                                    teacher[teacher.IndexOf(item)].TCode = editTeacher.TCode;

                                    Console.WriteLine("Edit Success");
                                    AwaitGoToMenu();
                                    goto loopmenu;
                                }


                            }
                            Console.WriteLine("Can not found ...");
                            AwaitGoToMenu();
                            goto loopmenu;
                        }
                        else
                        {
                            Console.WriteLine("Number Teacher = 0 ");
                            AwaitGoToMenu();
                            goto loopmenu;
                        }
                        break;
                    }
                case "4":
                    {
                        if (teacher.Count > 0)
                        {
                            Console.WriteLine("Enter teacher national code : ");
                            var Code = Convert.ToInt32(CheckNullableList());
                            foreach (var item in teacher)
                            {

                                if (item.NCode == Code)
                                {
                                    teacher.Remove(item);
                                    Console.WriteLine("Remove Item Success");
                                    AwaitGoToMenu();
                                    goto loopmenu;
                                }
                                else
                                {
                                    Console.WriteLine("Can not found ...");
                                    AwaitGoToMenu();
                                    goto loopmenu;
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Number teacher = 0 ");
                            AwaitGoToMenu();
                            goto loopmenu;
                        }

                        break;
                    }
                case "5":
                    {
                        Console.Clear();
                        goto loopmain;
                        break;
                    }
                default:
                    Console.WriteLine("Plz Select from Menu and enter : ");
                    goto loopdeff;
                    break;
            }



            break;
        }
    case "2":
        {

        loopmenu:
                Console.Clear();
                Console.WriteLine("Student Menu : ");
                Console.WriteLine("1. Student registration(Type num 1 and enter)");
                Console.WriteLine("2. List of Student(Type num 2 and enter)");
                Console.WriteLine("3. Edit Student Info(Type num 3 and enter)");
                Console.WriteLine("4. Remove Student(Type num 4 and enter)");
                Console.WriteLine("5. Exit to menu(Type num 5 and enter)");
           
            loopdeff:
                a = CheckNullableMenu();
                
                    Console.Clear();
                    switch (a)
                    {
                        case "1":
                            {
                                StudentModel creatStudent = new StudentModel ();
                                Console.WriteLine("Enter First Name : ");
                                creatStudent.FName = CheckNullableList();
                                
                                Console.WriteLine("Enter Last Name : ");
                                creatStudent.LName = CheckNullableList();

                                Console.WriteLine("Enter Student Code : ");
                                 creatStudent.SCode = Convert.ToInt32(CheckNullableList());

                                Console.WriteLine("Enter BD Date(y/m/d) : ");
                                 creatStudent.BDate = Convert.ToDateTime(CheckNullableList());

                                Console.WriteLine("Enter Score : ");
                                 creatStudent.Score = Convert.ToDouble(CheckNullableList()) ;

                        student.Add(new StudentModel
                        {
                            FName = creatStudent.FName,
                            LName = creatStudent.LName,
                            SCode = creatStudent.SCode,
                            BDate = creatStudent.BDate,
                            Score = creatStudent.Score
                        });
                        Console.WriteLine("Save Success");
                        AwaitGoToMenu();
                        goto loopmenu;

                            break;
                            }
                        case "2":
                            {
                        if (student.Count > 0)
                        {
                            Console.WriteLine("Student List : ");
                            ShowListStudent(student);
                            AwaitGoToMenu();
                            goto loopmenu;
                        }
                        else { 
                        Console.WriteLine("Can not found any student");
                            AwaitGoToMenu();
                            goto loopmenu;
                        }
                                break;
                            }
                        case "3":
                            {

                        if (student.Count > 0) {

                            Console.WriteLine("Enter Student Code : ");
                            var Code = Convert.ToInt32(CheckNullableList());
                            foreach (var item in student) {
                                
                                if (item.SCode == Code) {

                                    StudentModel editStudent = new StudentModel();
                                    Console.WriteLine("Enter New First Name : ");
                                    editStudent.FName = CheckNullableList();

                                    Console.WriteLine("Enter Last Name : ");
                                    editStudent.LName = CheckNullableList();


                                    editStudent.SCode = item.SCode;

                                    Console.WriteLine("Enter BD Date : ");
                                    editStudent.BDate = Convert.ToDateTime(CheckNullableList());

                                    Console.WriteLine("Enter Score : ");
                                    editStudent.Score = Convert.ToDouble(CheckNullableList());

                                    student[student.IndexOf(item)].FName = editStudent.FName; 
                                    student[student.IndexOf(item)].LName = editStudent.LName; 
                                    student[student.IndexOf(item)].SCode = editStudent.SCode; 
                                    student[student.IndexOf(item)].BDate = editStudent.BDate; 
                                    student[student.IndexOf(item)].Score = editStudent.Score; 
                                    
                                    Console.WriteLine("Edit Success");
                                    AwaitGoToMenu();
                                    goto loopmenu;
                                }
                                
                                
                            }
                            Console.WriteLine("Can not found ...");
                            AwaitGoToMenu();
                            goto loopmenu;
                        }
                        else
                        {
                            Console.WriteLine("Number Student = 0 ");
                            AwaitGoToMenu();
                            goto loopmenu;
                        }
                        break;
                            }
                        case "4":
                            {
                        if (student.Count > 0) {
                            Console.WriteLine("Enter Student Code : ");
                            var Code = Convert.ToInt32(CheckNullableList());
                            foreach (var item in student)
                            {
                                
                                if (item.SCode == Code)
                                {
                                    student.Remove(item);
                                    Console.WriteLine("Remove Item Success");
                                    AwaitGoToMenu();
                                    goto loopmenu;
                                }
                                else
                                {
                                    Console.WriteLine("Can not found ...");
                                    AwaitGoToMenu();
                                    goto loopmenu;
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Number Student = 0 ");
                            AwaitGoToMenu();
                            goto loopmenu;
                        }

                        break;
                            }
                        case "5":
                            {
                            Console.Clear();
                            goto loopmain;
                                break;
                            }
                        default:
                            Console.WriteLine("Plz Select from Menu and enter : ");
                             goto loopdeff;
                            break;
                    }



                break;
            }
        case "3":
        {

        loopmenu:
            Console.Clear();
            Console.WriteLine("Term Menu : ");
            Console.WriteLine("1. Term registration(Type num 1 and enter)");
            Console.WriteLine("2. List of Term(Type num 2 and enter)");
            Console.WriteLine("3. Edit Term Info(Type num 3 and enter)");
            Console.WriteLine("4. Remove Term(Type num 4 and enter)");
            Console.WriteLine("5. Exit to menu(Type num 5 and enter)");

        loopdeff:
            a = CheckNullableMenu();

            Console.Clear();
            switch (a)
            {
                case "1":
                    {
                        TermModel createTerm = new TermModel();
                        Console.WriteLine("Enter student Code : ");
                        createTerm.StuCode = Convert.ToInt32(CheckNullableList());

                        Console.WriteLine("Enter teacher Code : ");
                        createTerm.TeacherCode = Convert.ToInt32(CheckNullableList());

                        Console.WriteLine("Enter start term date(y/m/d) : ");
                        createTerm.StartTerm = Convert.ToDateTime(CheckNullableList());
                       
                        Console.WriteLine("Enter end term date(y/m/d) : ");
                        createTerm.EndTerm = Convert.ToDateTime(CheckNullableList());

                        Console.WriteLine("Enter term Code : ");
                        createTerm.TermCode = Convert.ToInt32(CheckNullableList());

                        Console.WriteLine("Enter term  name : ");
                        createTerm.TermName = CheckNullableList();

                        term.Add(new TermModel
                        {
                            StuCode = createTerm.StuCode,
                            TeacherCode = createTerm.TeacherCode,
                            StartTerm = createTerm.StartTerm,
                            EndTerm = createTerm.EndTerm,
                            TermCode = createTerm.TermCode,
                            TermName = createTerm.TermName,
                            
                        });
                        Console.WriteLine("Save Success");
                        AwaitGoToMenu();
                        goto loopmenu;

                        break;
                    }
                case "2":
                    {
                        if (term.Count > 0)
                        {
                            Console.WriteLine("Term List : ");
                            ShowListTerm(term);
                            AwaitGoToMenu();
                            goto loopmenu;
                        }
                        else
                        {
                            Console.WriteLine("Can not found any term");
                            AwaitGoToMenu();
                            goto loopmenu;
                        }
                        break;
                    }
                case "3":
                    {

                        if (term.Count > 0)
                        {

                            Console.WriteLine("Enter term code : ");
                            var Code = Convert.ToInt32(CheckNullableList());
                            foreach (var item in term)
                            {

                                if (item.TermCode == Code)
                                {

                                    TermModel editTerm = new TermModel();
                                    Console.WriteLine("Enter student new Code : ");
                                    editTerm.StuCode = Convert.ToInt32(CheckNullableList());

                                    Console.WriteLine("Enter teacher new Code : ");
                                    editTerm.TeacherCode = Convert.ToInt32(CheckNullableList());

                                    Console.WriteLine("Enter start term new date(y/m/d) : ");
                                    editTerm.StartTerm = Convert.ToDateTime(CheckNullableList());

                                    Console.WriteLine("Enter end term new date(y/m/d) : ");
                                    editTerm.EndTerm = Convert.ToDateTime(CheckNullableList());

                                    Console.WriteLine("Enter term new Code : ");
                                    editTerm.TermCode = Convert.ToInt32(CheckNullableList());

                                    Console.WriteLine("Enter term new name : ");
                                    editTerm.TermName = CheckNullableList();
                                    term[term.IndexOf(item)].StuCode = editTerm.StuCode;
                                    term[term.IndexOf(item)].TeacherCode = editTerm.TeacherCode;
                                    term[term.IndexOf(item)].StartTerm = editTerm.StartTerm;
                                    term[term.IndexOf(item)].EndTerm = editTerm.EndTerm;
                                    term[term.IndexOf(item)].TermCode = editTerm.TermCode;
                                    term[term.IndexOf(item)].TermName = editTerm.TermName;

                                    Console.WriteLine("Edit Success");
                                    AwaitGoToMenu();
                                    goto loopmenu;
                                }


                            }
                            Console.WriteLine("Can not found ...");
                            AwaitGoToMenu();
                            goto loopmenu;
                        }
                        else
                        {
                            Console.WriteLine("Number Term = 0 ");
                            AwaitGoToMenu();
                            goto loopmenu;
                        }
                        break;
                    }
                case "4":
                    {
                        if (term.Count > 0)
                        {
                            Console.WriteLine("Enter term code : ");
                            var Code = Convert.ToInt32(CheckNullableList());
                            foreach (var item in term)
                            {

                                if (item.TermCode == Code)
                                {
                                    term.Remove(item);
                                    Console.WriteLine("Remove Item Success");
                                    AwaitGoToMenu();
                                    goto loopmenu;
                                }
                                else
                                {
                                    Console.WriteLine("Can not found ...");
                                    AwaitGoToMenu();
                                    goto loopmenu;
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Number term = 0 ");
                            AwaitGoToMenu();
                            goto loopmenu;
                        }

                        break;
                    }
                case "5":
                    {
                        Console.Clear();
                        goto loopmain;
                        break;
                    }
                default:
                    Console.WriteLine("Plz Select from Menu and enter : ");
                    goto loopdeff;
                    break;
            }



            break;
        }
    case "4":
            {
            System.Environment.Exit(0);
            break;
            }

        default:
        Console.WriteLine("Plz Select from Menu and enter : ");
        goto loopmain;
        break;
    }



 string CheckNullableMenu()
{
loop10:
    a = Console.ReadLine();
    if (string.IsNullOrEmpty(a) && string.IsNullOrWhiteSpace(a))
    {
        Console.WriteLine("Plz Select from Menu and enter : ");
        goto loop10;
    }
    else {
    return a;
    }
}

string CheckNullableList()
{
loop1:
    a = Console.ReadLine();
    if (string.IsNullOrEmpty(a) && string.IsNullOrWhiteSpace(a))
    {
        Console.WriteLine("Plz enter Data : ");
        goto loop1;
    }
    else
    {
        return a;
    }
}
static void ShowListStudent(List<StudentModel> Stdlist)
{

    foreach (StudentModel element in Stdlist)
    {
        Console.WriteLine($"Student first name : {element.FName} , Student Last name : {element.LName} , Student code : {element.SCode} , Student  BD Date : {element.BDate} , Student Score : {element.Score}  ");
    }
}

static void ShowListTeacher(List<TeacherModel> Tlist)
{

    foreach (TeacherModel element in Tlist)
    {
        Console.WriteLine($"Student first name : {element.FName} , Student Last name : {element.LName} , Teacher code : {element.TCode} , Teacher National Code : {element.NCode}  ");
    }
}
static void ShowListTerm(List<TermModel> Tlist)
{

    foreach (TermModel element in Tlist)
    {
        Console.WriteLine($"Student Code : {element.StuCode} , Teacher Code : {element.TeacherCode} , Start Date : {element.StartTerm} , End Term : {element.EndTerm} ,Term Code : {element.TermCode} , Term Name : {element.TermName} ");
    }
}



static List<StudentModel> InitStu(List<StudentModel> stu) {

    stu.Add(new StudentModel
    {
        FName = "ali",
        LName = "ahmadi",
        SCode = 2251125,
        BDate = Convert.ToDateTime("1998/10/20"),
        Score = 97
    });
    stu.Add(new StudentModel
    {
        FName = "abbas",
        LName = "abbasi",
        SCode = 2278894,
        BDate = Convert.ToDateTime("1995/5/20"),
        Score = 95
    });
    stu.Add(new StudentModel
    {
        FName = "hosein",
        LName = "haeri",
        SCode = 1149977,
        BDate = Convert.ToDateTime("1997/6/15"),
        Score = 91
    });
    return stu;
}
static List<TeacherModel> InitTeacher(List<TeacherModel> tch)
{

    tch.Add(new TeacherModel
    {
        FName = "ali",
        LName = "ahmadi",
        TCode = 2251125,
        NCode = 258765881
    });
    tch.Add(new TeacherModel
    {
        FName = "abbas",
        LName = "ahraii",
        TCode = 515151851,
        NCode = 25652658
    });
    tch.Add(new TeacherModel
    {
        FName = "hashem",
        LName = "hasanzade",
        TCode = 548487765,
        NCode = 147786325
    });
    return tch;
}
static void AwaitGoToMenu() {
    Console.WriteLine("Go to menu ? Enter ");
    Console.ReadLine();
}