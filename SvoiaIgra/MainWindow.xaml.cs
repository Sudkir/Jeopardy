using System;
using System.Windows;

namespace SvoiaIgra
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()//загрузка окна
        {
            InitializeComponent();
            Score.Content = Convert.ToString(cl);
            QLabel.Content = "Выберите вопрос";
            QButton1.Content = "А";
            QButton2.Content = "B";
            QButton3.Content = "C";
            QButton4.Content = "D";
            qn = 0;
         
        }

        //
        public void Showinfo(int Question_ID)//выбор текста  из массива
        {

            ShowIdInfo(Item.Items[Question_ID].sQLable, Item.Items[Question_ID].sQbutton_1, Item.Items[Question_ID].sQbutton_2, Item.Items[Question_ID].sQbutton_3, Item.Items[Question_ID].sQbutton_4);


        }

        public void IFinfo()//вопрос уже выбран
        {
            MessageBox.Show("Вопрос уже выбран");

        }

        public void ShowIdInfo(string sQlab, string qdes1, string qdes2, string qdes3, string qdes4)//возвращает текст 
        {


            QLabel.Content = sQlab;

            QButton1.Content = qdes1;
            QButton2.Content = qdes2;
            QButton3.Content = qdes3;
            QButton4.Content = qdes4;
        }


        class Item //класс с 2 полями и конструктором
        {

            public string sQLable;
            public string sQbutton_1;
            public string sQbutton_2;
            public string sQbutton_3;
            public string sQbutton_4;

            public Item(string sQlab, string qdes1, string qdes2, string qdes3, string qdes4)//конструктор 
            {

                sQLable = sQlab;
                sQbutton_1 = qdes1;
                sQbutton_2 = qdes2;
                sQbutton_3 = qdes3;
                sQbutton_4 = qdes4;
            }

            public static Item[] Items = //массив из ОБ 
            {
            new Item("g0", "g1","g2","g3","g4"),
            new Item("Какая самая распространенная биометрическая технология аутентификации пользователей?", "По отпечаткам пальцев","По радужке глаза","По геометрии лица","По голосу"),//первый вопрос
        };
        }
        //

        int cl = 0;//Очки
        int qn = 0;//вопрос
        //+-очки
        int n1 = 100;
        int n2 = 200;
        int n3 = 300;
        int n4 = 400;

        int last_cl = 0;//счетчик вопросов для конца игры


        private void TrueBut(int n)//Верный ответ
        {
            cl += n;

            MessageBox.Show($"Это верный ответ +{n} баллов.");
            //возврат к пустому вопросу
            QLabel.Content = "Выберите вопрос";
            QButton1.Content = "А";
            QButton2.Content = "B";
            QButton3.Content = "C";
            QButton4.Content = "D";
            qn = 0;
            Score.Content = Convert.ToString(cl);
            //Конец игры
            last_cl++;
            if (last_cl >= 16)
            {
                MessageBox.Show($"Конец игры количество баллов ={cl}");
            }

        }

        private void FalseBut(int n)//Неверный ответ
        {
            cl -= n;

            MessageBox.Show($"Это неверный ответ -{n} баллов.");

            QLabel.Content = "Выберите вопрос";
            QButton1.Content = "А";
            QButton2.Content = "B";
            QButton3.Content = "C";
            QButton4.Content = "D";
            qn = 0;
            Score.Content = Convert.ToString(cl);

            last_cl++;
            if (last_cl >= 16)
            {
                MessageBox.Show($"Конец игры количество баллов ={cl}");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)// об игре
        {
            MessageBox.Show($"Сделал Судариков Кирилл все права не защищены.");
        }



        private void Button_Click(object sender, RoutedEventArgs e)//новая игра
        {
            cl = 0;
            QLabel.Content = "Выберите вопрос";
            QButton1.Content = "А";
            QButton2.Content = "B";
            QButton3.Content = "C";
            QButton4.Content = "D";
            qn = 0;
            Score.Content = Convert.ToString(cl);
            btn1.Visibility = Visibility.Visible;
            btn2.Visibility = Visibility.Visible;
            btn3.Visibility = Visibility.Visible;
            btn4.Visibility = Visibility.Visible;
            btn5.Visibility = Visibility.Visible;
            btn6.Visibility = Visibility.Visible;
            btn7.Visibility = Visibility.Visible;
            btn8.Visibility = Visibility.Visible;
            btn9.Visibility = Visibility.Visible;
            btn10.Visibility = Visibility.Visible;
            btn11.Visibility = Visibility.Visible;
            btn12.Visibility = Visibility.Visible;
            btn13.Visibility = Visibility.Visible;
            btn14.Visibility = Visibility.Visible;
            btn15.Visibility = Visibility.Visible;
            btn16.Visibility = Visibility.Visible;


        }

        private void QButton1_Click(object sender, RoutedEventArgs e)//ответ 1
        {


            if (qn <= 16 && qn > 0)
            {
                switch (qn)
                {
                    case 1:
                        TrueBut(n1);
                        break;

                    case 2:
                        FalseBut(n2);
                        break;

                    case 3:
                        FalseBut(n3);
                        
                        break;

                    case 4:
                        TrueBut(n4);
                        break;

                    case 5:
                        FalseBut(n1);
                        break;

                    case 6:
                        FalseBut(n2);
                        break;

                    case 7:
                        FalseBut(n3);
                        break;

                    case 8:
                        FalseBut(n4);
                        break;
                    case 9:
                        TrueBut(n1);
                        break;
                    case 10:
                        FalseBut(n2);
                        break;

                    case 11:
                        FalseBut(n3);
                        break;

                    case 12:
                        FalseBut(n4);
                        break;
                    case 13:
                        TrueBut(n1);
                        break;

                    case 14:
                        TrueBut(n2);
                        break;
                    case 15:
                        FalseBut(n3);
                        break;

                    case 16:
                        FalseBut(n4);
                        break;


                }
            }
            else
            {
                MessageBox.Show("Выберите вопрос");
            }

        }

        private void QButton2_Click(object sender, RoutedEventArgs e)//ответ 2
        {


            if (qn <= 16 && qn > 0)
            {
                switch (qn)
                {
                    case 1:
                        FalseBut(n1);
                        break;

                    case 2:
                        TrueBut(n2);
                        break;

                    case 3:
                        FalseBut(n3);
                        break;

                    case 4:
                        FalseBut(n4);
                        break;

                    case 5:
                        TrueBut(n1);
                        break;

                    case 6:
                        FalseBut(n2);
                        break;

                    case 7:
                        FalseBut(n3);
                        break;

                    case 8:
                        TrueBut(n4);
                        break;
                    case 9:
                        FalseBut(n1);
                        break;
                    case 10:

                        FalseBut(n2);
                        break;

                    case 11:

                        TrueBut(n3);
                        break;

                    case 12:
                        FalseBut(n4);
                        break;
                    case 13:
                        FalseBut(n1);
                        break;

                    case 14:
                        FalseBut(n2);
                        break;
                    case 15:
                        FalseBut(n3);
                        break;

                    case 16:
                        FalseBut(n4);
                        break;

                }
            }
            else
            {
                MessageBox.Show("Выберите вопрос");
            }

        }

        private void QButton3_Click(object sender, RoutedEventArgs e)//ответ 3
        {


            if (qn <= 16 && qn > 0)
            {
                switch (qn)
                {
                    case 1:
                        FalseBut(n1);
                        break;

                    case 2:

                        FalseBut(n2);
                        break;

                    case 3:

                        FalseBut(n3);
                        break;

                    case 4:

                        FalseBut(n4);
                        break;

                    case 5:

                        FalseBut(n1);
                        break;

                    case 6:

                        FalseBut(n2);
                        break;

                    case 7:

                        TrueBut(n3);
                        break;

                    case 8:

                        FalseBut(n4);
                        break;
                    case 9:
            
                        FalseBut(n1);
                        break;
                    case 10:
                        TrueBut(n2);
                        break;

                    case 11:

                        FalseBut(n3);
                        break;

                    case 12:

                        TrueBut(n4);
                        break;
                    case 13:

                        FalseBut(n1);
                        break;

                    case 14:
                        FalseBut(n2);
                        break;
                    case 15:
                        FalseBut(n3);
                        break;

                    case 16:
                        FalseBut(n4);
                        break;

                }
            }
            else
            {
                MessageBox.Show("Выберите вопрос");
            }

        }

        private void QButton4_Click(object sender, RoutedEventArgs e)//ответ 4
        {


            if (qn <= 16 && qn > 0)
            {
                switch (qn)
                {
                    case 1:
                        FalseBut(n1);
                        break;

                    case 2:
                        FalseBut(n2);
                        break;

                    case 3:
                        TrueBut(n3);
                        break;

                    case 4:
                        FalseBut(n4);
                        break;

                    case 5:

                        FalseBut(n1);
                        break;

                    case 6:

                        TrueBut(n2);
                        break;

                    case 7:
                        FalseBut(n3);
                        break;

                    case 8:
                        FalseBut(n4);
                        break;
                    case 9:
                        FalseBut(n1);
                        break;
                    case 10:
                        FalseBut(n2);
                        break;

                    case 11:
                        FalseBut(n3);
                        break;

                    case 12:
                        FalseBut(n4);
                        break;
                    case 13:
                        FalseBut(n1);
                        break;

                    case 14:
                        FalseBut(n2);
                        break;
                    case 15:
                        TrueBut(n3);
                        break;

                    case 16:
                        TrueBut(n4);
                        break;

                }
            }
            else
            {
                MessageBox.Show("Выберите вопрос");
            }

        }



        private void Btn1_Click(object sender, RoutedEventArgs e)// вопрос 1
        {

            if (qn <= 0)
            {
                qn = 1;
                btn1.Visibility = Visibility.Hidden;
                Showinfo(qn);
            }
            else IFinfo();

        }

        private void Btn2_Click(object sender, RoutedEventArgs e)//вопрос 2
        {
            if (qn <= 0)
            {
                QLabel.Content = "Какое излучение использует метод аутентификации по сетчатке глаза?";
                btn2.Visibility = Visibility.Hidden;
                QButton1.Content = "Рентгеновское излучение";
                QButton2.Content = "Инфракрасное излучение";
                QButton3.Content = "Ультрафиолетовый свет";
                QButton4.Content = "Видимый свет";
                qn = 2;
            }
            else
            {
                MessageBox.Show("Вопрос уже выбран");
            }

        }

        private void Btn3_Click(object sender, RoutedEventArgs e)//вопрос 3
        {

            if (qn <= 0)
            {
                QLabel.Content = "Что не относиться к динамическим методам аутентификации?";
                btn3.Visibility = Visibility.Hidden;
                QButton1.Content = "Голос";
                QButton2.Content = "Клавиатурный почерк";
                QButton3.Content = "Подпись";
                QButton4.Content = "Геометрия руки";
                qn = 3;
            }
            else
            {
                MessageBox.Show("Вопрос уже выбран");
            }

        }

        private void Btn4_Click(object sender, RoutedEventArgs e)//вопрос 4
        {
            if (qn <= 0)
            {
                QLabel.Content = "Выберите метод создания защищенного эскиза который обозначили ИТ-специалисты?";
                btn4.Visibility = Visibility.Hidden;
                QButton1.Content = "fuzzy commitment";
                QButton2.Content = "fuzzy logic";
                QButton3.Content = "fuzzy lookup";
                QButton4.Content = "fuzzy search";
                qn = 4;
            }
            else
            {
                MessageBox.Show("Вопрос уже выбран");
            }

        }

        private void Btn5_Click(object sender, RoutedEventArgs e)//вопрос 5
        {
            if (qn <= 0)
            {
                QLabel.Content = "Какой штриховой код символики EAN/UPC включает 13 цифр?";
                btn5.Visibility = Visibility.Hidden;
                QButton1.Content = "EAN-8";
                QButton2.Content = "EAN-13";
                QButton3.Content = "UPC-A";
                QButton4.Content = "UPC-Е";
                qn = 5;
            }
            else
            {
                MessageBox.Show("Вопрос уже выбран");


            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)//вопрос 6
        {
            if (qn <= 0)
            {
                QLabel.Content = "Как переводиться QR-код ?";
                btn6.Visibility = Visibility.Hidden;
                QButton1.Content = "Quick Reply";
                QButton2.Content = "Quick Ratio";
                QButton3.Content = "Quick Run";
                QButton4.Content = "Quick Response ";
                qn = 6;
            }
            else
            {
                MessageBox.Show("Вопрос уже выбран");


            }

        }

        private void Btn7_Click(object sender, RoutedEventArgs e)//вопрос 7
        {
            if (qn <= 0)
            {
                QLabel.Content = " в каком году QR-код был представлен японской компанией Denso-Wave?";
                btn7.Visibility = Visibility.Hidden;
                QButton1.Content = "1990";
                QButton2.Content = "1992";
                QButton3.Content = "1994";
                QButton4.Content = "2001";
                qn = 7;
            }
            else
            {
                MessageBox.Show("Вопрос уже выбран");


            }

        }

        private void Btn9_Click(object sender, RoutedEventArgs e)//вопрос 9
        {
            if (qn <= 0)
            {
                QLabel.Content = "На чем основан принцип идентификации RFID?";
                btn9.Visibility = Visibility.Hidden;
                QButton1.Content = "Радиосигнал";
                QButton2.Content = "SIM-чип";
                QButton3.Content = "Wi-Fi";
                QButton4.Content = "Магнитная лента";
                qn = 9;
            }
            else
            {
                MessageBox.Show("Вопрос уже выбран");


            }

        }

        private void Btn8_Click(object sender, RoutedEventArgs e)//вопрос 8
        {
            if (qn <= 0)
            {
                QLabel.Content = "Определите производителя по номеру штрих-кода от 460 до 469?";
                btn8.Visibility = Visibility.Hidden;
                QButton1.Content = "США";
                QButton2.Content = "Россия";
                QButton3.Content = "Канада";
                QButton4.Content = "ОАЭ";
                qn = 8;
            }
            else
            {
                MessageBox.Show("Вопрос уже выбран");


            }

        }

        private void Btn10_Click(object sender, RoutedEventArgs e)//вопрос 10
        {
            if (qn <= 0)
            {
                QLabel.Content = "На смартфонах технология беспроводной передачи данных малого радиуса действия это?";
                btn10.Visibility = Visibility.Hidden;
                QButton1.Content = "CCP";
                QButton2.Content = "NPC";
                QButton3.Content = "NFC";
                QButton4.Content = "CNN";
                qn = 10;
            }
            else
            {
                MessageBox.Show("Вопрос уже выбран");


            }

        }

        private void Btn11_Click(object sender, RoutedEventArgs e)//вопрос 11
        {
            if (qn <= 0)
            {
                QLabel.Content = "В каком году MasterCard начало использование технологии PayPass?";
                btn11.Visibility = Visibility.Hidden;
                QButton1.Content = "1999";
                QButton2.Content = "2003";
                QButton3.Content = "2005";
                QButton4.Content = "2012";
                qn = 11;
            }
            else
            {
                MessageBox.Show("Вопрос уже выбран");


            }

        }

        private void Btn12_Click(object sender, RoutedEventArgs e)//вопрос 12
        {
            if (qn <= 0)
            {
                QLabel.Content = "Как называется стандарт протокол обмена бесконтактных пассивных карт?";
                btn12.Visibility = Visibility.Hidden;
                QButton1.Content = "ISO/IEC 1448";
                QButton2.Content = "ISO/IEC 24242";
                QButton3.Content = "ISO/IEC 14443";
                QButton4.Content = "ISO/IEC 960";
                qn = 12;
            }
            else
            {
                MessageBox.Show("Вопрос уже выбран");


            }

        }

        private void Btn13_Click(object sender, RoutedEventArgs e)//вопрос 13
        {
            if (qn <= 0)
            {
                QLabel.Content = "Метод имеющий более одного доказательства аутентификации это?";
                btn13.Visibility = Visibility.Hidden;
                QButton1.Content = "Многофакторная";
                QButton2.Content = "Авторизация";
                QButton3.Content = "Двойная";
                QButton4.Content = "Паролинг";
                qn = 13;
            }
            else
            {
                MessageBox.Show("Вопрос уже выбран");

            }

        }

        private void Btn14_Click(object sender, RoutedEventArgs e)//вопрос 14
        {
            if (qn <= 0)
            {
                QLabel.Content = "Пароль, действительный только для одного сеанса аутентификации это?";
                btn14.Visibility = Visibility.Hidden;
                QButton1.Content = "Одноразовый пароль";
                QButton2.Content = "Многоразовый пароль";
                QButton3.Content = "Смарт-пароль";
                QButton4.Content = "Пароль GGF";
                qn = 14;
            }
            else
            {
                MessageBox.Show("Вопрос уже выбран");


            }

        }

        private void Btn15_Click(object sender, RoutedEventArgs e)//вопрос 15
        {
            if (qn <= 0)
            {
                QLabel.Content = "Если авторизация требует код из SMS и пароль то это?";
                btn15.Visibility = Visibility.Hidden;
                QButton1.Content = "Смартификация";
                QButton2.Content = "ITфикация";
                QButton3.Content = "Дуофикация ";
                QButton4.Content = "Двухфакторная аутентификация ";
                qn = 15;
            }
            else
            {
                MessageBox.Show("Вопрос уже выбран");


            }

        }

        private void Btn16_Click(object sender, RoutedEventArgs e)//вопрос 16
        {
            if (qn <= 0)
            {
                QLabel.Content = "Выберите самый надежный пароль?";
                btn16.Visibility = Visibility.Hidden;
                QButton1.Content = "vasia";
                QButton2.Content = "admin";
                QButton3.Content = "oleg99";
                QButton4.Content = "ViKtOr312";
                qn = 16;
            }
            else
            {
                MessageBox.Show("Вопрос уже выбран");


            }

        }

       
    }
}
