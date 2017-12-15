using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Pic;  //สถาณะของรูป 

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random zxc = new Random();  //สร้างตัวแปล แลนด้อม
            int bb = zxc.Next(1, 21);  //จัดเก็บตัวแปล เเลนด้อม เพื่อสุ่มตัวเลข (1,21)
            button3.Enabled = true;  //ทำใหปุ่มกดได้
            button4.Enabled = true;  //ทำให้ปุ่มกดได้
            button5.Enabled = true;  //ทำให้ปุ่มกดได้
            button6.Enabled = true;  //ทำให้ปุ่มกดได้
            switch (bb)  //ตรวจสอบเงื่อนไข
            {
                case 1: pictureBox1.Image = Properties.Resources.a1;  //ถ้าสุ่มเเล้วได้ 1 มันจะทำการโชว์รูปที่ 1
                    Pic = 1;  //สถาณะของรูปภาพ
                    button3.Text = "Motorcycle"; button4.Text = "Shose";button5.Text = "Turtle";button6.Text = "Rocket";  //กำหนดคำตอบ
                    break;  //คำสั้งหยุด
                    
                case 2:
                    pictureBox1.Image = Properties.Resources.a2;  //ถ้าสุ่มแล้วได้ 2 มันจะทำการโชว์รูปที่ 2
                    Pic = 2;  //สถาณะของรูปภาพ
                    button3.Text = "Bird"; button4.Text = "Cat"; button5.Text = "Lion"; button6.Text = "Tiger";  //กำหนดคำตอบ
                    break;  //คำสั่งหยุด
                case 3:
                    pictureBox1.Image = Properties.Resources.a3;  //ถ้าสุ่มแล้วได้ 3 มันจะโชว์รูปภาพที่ 2
                    Pic = 3;  //สถาณะของรูปภาพ
                    button3.Text = "Camera"; button4.Text = "Glass"; button5.Text = " Girl"; button6.Text = "Box";  //กำหนดคำตอบ
                    break;  //คำสั่งหยุด
                case 4:
                    pictureBox1.Image = Properties.Resources.a4;  //ถ้าสุ่มแล้วได้ 4 มันจะโชว์รูปภาพที่ 4
                    Pic = 4;  //สถาณะของรูปภาพ
                    button3.Text = "Door"; button4.Text = "Dog"; button5.Text = "Farm"; button6.Text = "Pig";  //กำหนดคำตอบ
                    break;  //คำสั่งหยุด
                case 5:
                    pictureBox1.Image = Properties.Resources.a5;  //ถ้าสุ่มแล้วได้ 5 มันจะโชว์ 5
                    Pic = 5;  //สถาณะของรูปภาพ
                    button3.Text = "Boat"; button4.Text = "Cake"; button5.Text = "Tiger"; button6.Text = "Duck";  //กำหนดคำตอบ
                    break;  //คำสั่งหยุด
                case 6:
                    pictureBox1.Image = Properties.Resources.a6;
                    Pic = 6;
                    button3.Text = "Forest"; button4.Text = "Sock"; button5.Text = "Book"; button6.Text = "Bat";
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.a7;
                    Pic = 7;
                    button3.Text = "Orange"; button4.Text = "Market"; button5.Text = "Banana"; button6.Text = "Hat";
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.a8;
                    Pic = 8;
                    button3.Text = "Monkey"; button4.Text = "Glass"; button5.Text = "Glove"; button6.Text = "Apple";
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.a9;
                    Pic = 9;
                    button3.Text = "Island"; button4.Text = "Chick"; button5.Text = "Sport car"; button6.Text = "Bear";
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.a10;
                    Pic = 10;
                    button3.Text = "Boy"; button4.Text = "Starwberry"; button5.Text = "Heart"; button6.Text = "Money";
                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources.a11;
                    Pic = 11;
                    button3.Text = "Clock"; button4.Text = "Cutter"; button5.Text = "Pants"; button6.Text = "Bed";
                    break;
                case 12:
                    pictureBox1.Image = Properties.Resources.a12;
                    Pic = 12;
                    button3.Text = "Bread"; button4.Text = "Rat"; button5.Text = "Knife"; button6.Text = "Glass";
                    break;
                case 13:
                    pictureBox1.Image = Properties.Resources.a13;
                    Pic = 13;
                    button3.Text = "Flag"; button4.Text = "Fridge"; button5.Text = "Phone"; button6.Text = "Hand";
                    break;
                case 14:
                    pictureBox1.Image = Properties.Resources.a14;
                    Pic = 14;
                    button3.Text = "Bike"; button4.Text = "Corn"; button5.Text = "Gun"; button6.Text = "Bus";
                    break;
                case 15:
                    pictureBox1.Image = Properties.Resources.a15;
                    Pic = 15;
                    button3.Text = "Cow"; button4.Text = "Coffee"; button5.Text = "Mountain "; button6.Text = "Earth";
                    break;
                case 16:
                    pictureBox1.Image = Properties.Resources.a16;
                    Pic = 16;
                    button3.Text = "Pen"; button4.Text = "Snake"; button5.Text = "Chair"; button6.Text = "Beer";
                    break;
                case 17:
                    pictureBox1.Image = Properties.Resources.a17;
                    Pic = 17;
                    button3.Text = "Hen"; button4.Text = "Pencil"; button5.Text = "Mouse"; button6.Text = "Fruit";
                    break;
                case 18:
                    pictureBox1.Image = Properties.Resources.a18;
                    Pic = 18;
                    button3.Text = "Food"; button4.Text = "Plane"; button5.Text = "Ruler"; button6.Text = "Home";
                    break;
                case 19:
                    pictureBox1.Image = Properties.Resources.a19;
                    Pic = 19;
                    button3.Text = "Foot"; button4.Text = "Guitar"; button5.Text = "Feather"; button6.Text = "Horse";
                    break;
                case 20:
                    pictureBox1.Image = Properties.Resources.a20;
                    Pic = 20;
                    button3.Text = "Nose"; button4.Text = "Car"; button5.Text = "Ring"; button6.Text = "Insect";
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Motorcycle"|| button3.Text == "Orange" || button3.Text == "Camera" || button3.Text == "Clock" || button3.Text == "Bike" || button3.Text == "Pen")  
                //ถ้าเท็กบล็อคมีชื่อตามที่กำหนดไว้
            {
                label3.Text = Convert.ToString(int.Parse(label3.Text) + 10);  //จะเพิ่มคะแนนทีละ 10
                MessageBox.Show("คุณตอบถูก");  //ถ้าตอบถูกจะโชว์คำว่า (คุณตอบถูก)
                button2_Click(sender, e);  //คำสั่งกดปุ่มอัตโนมัติ
            }
            else
            {
                wrong();  //เรียกใช้เม็ดตอด
                button2_Click(sender, e);  //คำสั่งกดปุ่มอัตโนมัติ
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int boss = Convert.ToInt32(label5.Text);  //สร้าตัวแปล อิน เพื่อแทรค่าใน ลาเบลล์
            boss = boss - 1;  //ค่าของตัวแปลลดลงทีละ 1
            label5.Text = Convert.ToString(boss);  //แปลงค่าให้เป็นสติง
            if (boss == 0)  //ถ้า บอส == 0 
            {
                label5.Text = "60";  //ให้ ลาเบลล์ มีค่าเท่ากับ 60 จะลดลงไปเลื่อยๆ
                label4.Text = Convert.ToString(int.Parse(label4.Text) - 1);  //รับค่ามาเล้วจะลดลงทีละ 1 
                if (label4.Text == "0")  //กำหนดค่าให้ ลาเบลล์ เป็น 0
                {
                    label4.Text = "00";  //กำหนดให้ ลาเบลล์ เวลาเป็น 00
                    label5.Text = "00";  //กำหนดให้ ลาเบลล์ เวลาเป็น 00
                    timer1.Stop();  //หยุดการจับเวลา
                    MessageBox.Show("ได้คะแนนทั้งหมด : " + label3.Text);  //หลังจกาทำงานเสร็จจะโชว์ผลคะแนนทั้งหมด  
                    Close();  //ปุ่มปิด
                } 
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(button6.Text=="Pig"|| button6.Text == "Apple")  //ถ้าเท็กบล็อคมีชื่อตามที่กำหนดไว้
            {
                label3.Text = Convert.ToString(int.Parse(label3.Text) + 10);  //จะเพิ่มคะแนนทีละ 10
                MessageBox.Show("คุณตอบถูก");  //ถ้าตอบถูกจะโชวขึ้นว่า (คุณตอบถูก)
                button2_Click(sender, e);  //คำสั่งกดปุ่มอัตโนมัติ
            }
            else
            {
                wrong();  //เช็คเม็ดตอด
                button2_Click(sender, e);  //คำสั่งกดปุ่มอัตโนมัติ
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;  //ซ่อนปุ่ม
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();  //เริ่มจับเวลา
            label4.Text = "14";  //กดหนดให้เป็นเลข 14
            label5.Text = "60";  //กดหนดให้เป็นเลข 60
            button1.Visible = false;  //ซ่อนปุ่ม 1 
            button2.Visible = true;  //เปิดปุ่ม 2
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(button4.Text=="Starwberry"|| button4.Text == "Coffee" || button4.Text == "Pencil" || button4.Text == "Plane" || button4.Text == "Guitar")
                //ถ้าเท็กบล็อคมีชื่อตามที่กำหนดไว้
            {
                label3.Text = Convert.ToString(int.Parse(label3.Text) + 10);  //จะเพิ่มทีละ 10
                MessageBox.Show("คุณตอบถูก");  //ถ้าตอบถูกจะขึ้นว่า (คุณตอบถูกต้อง)
                button2_Click(sender, e);  //คำสั่งกดปุ่มอัตโนมัติ
            }
            else
            {
                wrong();  //เช็คเม็ดตอด
                button2_Click(sender, e);  //คำสั่งกดปุ่มอัตโนมัติ
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(button5.Text == "Lion"|| button5.Text == "Tiger" || button5.Text == "Book" || button5.Text == "Sport car" || button5.Text == "Knife" || button5.Text == "Phone"|| button5.Text == "Ring")
            //ถ้าเท็กบล็อคมีชื่อตามที่กำหนดไว้
            {
                label3.Text = Convert.ToString(int.Parse(label3.Text) + 10);  //จะเพิ่มทีละ 10
                MessageBox.Show("คุณตอบถูก");  //ถ้าตอบถูกจะขึ้นว่า (คุณตอบถูกต้อง)
                button2_Click(sender, e);    //คำสั่งกดปุ่มอัตโนมัติ
            }
            else
            {
                wrong();  //เช็คเม็ดตอด
                button2_Click(sender, e);  //คำสั่งกดปุ่มอัตโนมัติ
            }
        }
        void wrong()  //สร้างเม็ดตอดเวลาตอบผิด
        {
            label3.Text = Convert.ToString(int.Parse(label3.Text) - 5);  //ถ้าคุณตอบผิดจะลดลงทีละ 5  
            MessageBox.Show("คุณตอบผิด");  //ถ้าคุณตอบผิดจะโชว์ขึ้นว่า (คุณตอบผิด)
            if (int.Parse(label3.Text) < 0)  //ถ้าคะแนนน้อยกว่า 0 
            {
                timer1.Stop();  //จะหยุดเวลา
                MessageBox.Show("Game Over!!!!" + "\r\n" + "ได้คะแนนทั้งหมด : " + label3.Text);  //แล้วจะขึ้นโชว์ว่าเกมส์ โอเวอร์
                Application.Exit();
            }
            
        }
    }
}
