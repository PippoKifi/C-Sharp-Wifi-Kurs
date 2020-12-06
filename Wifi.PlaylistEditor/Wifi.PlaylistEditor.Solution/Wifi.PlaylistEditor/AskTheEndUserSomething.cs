using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wifi.PlaylistEditor
{
    public class AskTheEndUserSomething
    {
        private string _questionToEndUser;
        private string _replayFromEndUser;
        private Form _myCommForm;
        private Label _label_Question = new Label();
        private TextBox _textBox_Answer = new TextBox();
        private TextBox _button_FinishToAnwer = new TextBox();
        private bool _whitFeedback;
        private string _deliverAnwer;

        //################
        //### KONSTRUKTOR ###
        public AskTheEndUserSomething(string questionToEndUser, bool whitFeedback)
        {
            _whitFeedback = whitFeedback;
            _questionToEndUser = questionToEndUser;
            MyCommForm = new Form();
        }

        //#####################
        //### EIGENSCHAFTEN ###
        public string QuestionToEndUser
        {
            set { _questionToEndUser = value; }
        }

        public string ReplayFromEndUser
        {
            get { return _replayFromEndUser; }
            set { _replayFromEndUser = value; }
        }

        private Form MyCommForm
        {
            set 
            {
                _myCommForm = value;
                createMyForm(); //Form erstellung starten
            }
        }


        //################
        //### METHODEN ###
        public void createMyForm()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));

            //Draw Form
            _myCommForm.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            _myCommForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            _myCommForm.ClientSize = new System.Drawing.Size(575, 125);
            _myCommForm.Name = "Form_Question_DummyForCloning";
            _myCommForm.Text = "Form_Question_DummyForCloning";
            _myCommForm.ResumeLayout(false);

            //Add _label_Question
            _label_Question.AutoSize = true;
            _label_Question.Location = new System.Drawing.Point(6, 4);
            _label_Question.Name = "label_Question";
            _label_Question.Size = new System.Drawing.Size(160, 17);
            _label_Question.TabIndex = 0;
            _label_Question.Text = _questionToEndUser;

            //Add _textBox_Answer
            if (_whitFeedback) 
            { 
            _textBox_Answer.Location = new System.Drawing.Point(6, 25);
            _textBox_Answer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            _textBox_Answer.Name = "textBox_Answer";
            _textBox_Answer.Size = new System.Drawing.Size(349, 23);
            _textBox_Answer.TabIndex = 1;
 
            //Add Button_FinishToAnwer
            _button_FinishToAnwer.Location = new System.Drawing.Point(6, 49);
            _button_FinishToAnwer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _button_FinishToAnwer.Name = "button_FinishToAnwer";
            _button_FinishToAnwer.Size = new System.Drawing.Size(75, 31);
            _button_FinishToAnwer.TabIndex = 2;
            _button_FinishToAnwer.Text = "Fertig";
            _button_FinishToAnwer.Click += new EventHandler(button_FinishToAnwer_Click); //Handler auf Klick Event abbonieren
            }

            _myCommForm.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            _myCommForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            _myCommForm.ClientSize = new System.Drawing.Size(359, 81);
            if (_whitFeedback)
            {
             _myCommForm.Controls.Add(_button_FinishToAnwer);
            _myCommForm.Controls.Add(_textBox_Answer);
            }
                _myCommForm.Controls.Add(_label_Question);
            _myCommForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            _myCommForm.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            _myCommForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            _myCommForm.Name = "Form_Question_DummyForCloning";
            _myCommForm.Text = "Form_Question_DummyForCloning";
            _myCommForm.ResumeLayout(false);
            _myCommForm.PerformLayout();
            _myCommForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //Form anzeigen
            _myCommForm.ShowDialog(); //Form anzeigen
        }


        private void button_FinishToAnwer_Click(object sender, EventArgs e)
        {
            _replayFromEndUser = _textBox_Answer.Text;
            _myCommForm.Close(); //Form schließen
        }




    }
}
