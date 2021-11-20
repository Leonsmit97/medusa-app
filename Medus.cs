int count = 1;
        int count1 = 0;
        Random num = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            timer1.Interval = 100;

            for (int i = 0; i < 1000; i++)
            {
                timer1.Start();
                count = i;
                
                Interaction.InputBox("System Malware Detected Error: 401 \n\n\n\nPlease Report Error:", "Windows Defender", "", num.Next(0, 1000), num.Next(0,730));

            }
           

        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            count1++;
            if (count1 <= count)
            {
                Interaction.InputBox("System Malware Detected Error: 401 \n\n\n\nPlease Report Error:", "Windows Defender", "", num.Next(0, 1000), num.Next(0, 730));
            }
            else
            {
                timer1.Stop();
                count1 = 0;
            }
        }
