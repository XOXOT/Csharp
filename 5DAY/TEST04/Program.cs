using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex4ForClass
{
    public interface Inotice
    { }

    class Announcement: Inotice
    {
        private Student student;
        private EMP emp;
        private string noticeMsg;

        public Announcement(Student student)
        {
            this.student = student;
        }
        public Announcement(EMP emp)
        {
            this.emp = emp;
        }

        public void norifyStudents()
        {
            student.update(this.noticeMsg);
        }

        public void norifyEMP()
        {
            emp.update(this.noticeMsg);
        }

        public void setNoticeMsg(string newNoticeMsg)
        {
            this.noticeMsg = newNoticeMsg;
            this.norifyStudents();
            this.norifyEMP();
        }
    }

    class Student: Inotice
    {
        private string noticeMsg;
        private Announcement announce;
        private string stuName;

        public Student(string stuName)
        {
            this.stuName = stuName;
        }

        public void update(string newNoticeMsg)
        {
            this.noticeMsg = newNoticeMsg;
            display();
        }

        public void registerAnnouncement(Announcement announce)
        {
            this.announce = announce;
        }

        public void display()
        {
            Console.WriteLine($"{this.stuName} 학생을 위한 새로운 공지 : {this.noticeMsg}");
        }
    }

    class EMP : Inotice
    {
        private string noticeMsg;
        private Announcement announce;
        private string empName;

        public EMP(string empName)
        {
            this.empName = empName;
        }

        public void update(string newNoticeMsg)
        {
            this.noticeMsg = newNoticeMsg;
            display();
        }

        public void registerAnnouncement(Announcement announce)
        {
            this.announce = announce;
        }

        public void display()
        {
            Console.WriteLine($"{this.empName} 교직원을 위한 새로운 공지 : {this.noticeMsg}");
        }
    }


    class MainApp
    {
        static void Main(string[] args)
        {
            Student student = new Student("홍길동");
            Announcement anounce = new Announcement(student);
            student.registerAnnouncement(anounce);

            EMP emp = new EMP("교직원");
            Announcement anounce1 = new Announcement(emp);
            emp.registerAnnouncement(anounce1);

            anounce.setNoticeMsg("첫 번째 공지 입니다.");
            anounce1.setNoticeMsg("첫 번째 공지 입니다.");
        }
    }
}
