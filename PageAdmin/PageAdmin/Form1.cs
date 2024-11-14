namespace Admin_Page
{
    using System.Diagnostics;
    using System.Drawing;
    using System.Reflection.Emit;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //To execute all methods once the Form was displayed
        private void Form1_Load(object sender, EventArgs e)
        {
            NavCustomize();
            MainContainerCustomize();
        }



        //Resize the header or navigation at the top of the form
        private void navpanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle screensize = Screen.PrimaryScreen.Bounds;

            int height = (int)(screensize.Height * 0.15);
            int width = screensize.Width;

            navpanel.Size = new Size(width, height);
            navpanel.BackColor = Color.FromArgb(203, 7, 7);
        }



        //Customize components inside navpanel
        private void NavCustomize()
        {
            header_text.Font = new Font("Arial", 18, FontStyle.Bold);
            header_logo.Size = new Size(120, 120);

            header_logo.Top = 10;
            header_logo.Left = header_text.Right + 80;

            header_text.Left = (int)(navpanel.Width * 0.77);
        }

        //A function that starts to display file explorer
        private void OpenFile()
        {
            Process.Start("explorer.exe");

        }



        private void MainContainerCustomize()
        {
            //Resize maincontainer and panels inside it in a full screen size

            int mainwidth = body.Width;
            int mainheight = body.Height - navpanel.Height;

            maincontainer.Size = new Size(mainwidth, mainheight);
            maincontainer.Location = new Point(0, navpanel.Bottom);

            //Resize leftcontainer to a 40% of the size of maincontainer(full-screen size)

            int leftheight = maincontainer.Height;
            int leftwidth = (int)(maincontainer.Width * 0.4);

            left_side.Size = new Size(leftwidth, leftheight);

            //Resize components of left side container

            top_leftside.Width = left_side.Width;
            middle_leftside.Width = left_side.Width;
            bottom_leftside.Width = left_side.Width;

            top_leftside.Height = (int)(left_side.Height * 0.3);
            middle_leftside.Height = (int)(left_side.Height * 0.6);
            bottom_leftside.Height = (int)(left_side.Height * 0.1);

            //Relocate components of left side container

            top_leftside.Location = new Point(0, 0);
            middle_leftside.Top = top_leftside.Bottom;
            bottom_leftside.Top = middle_leftside.Bottom;



            //Resize top panel components in left side of maincontainer 
            
            top_image.Size = new Size(160, 180);
            top_admintext.Font = new Font("Arial", 18, FontStyle.Bold);
            top_profile.Font = new Font("Arial", 16, FontStyle.Regular);

            int allheight = top_image.Height + top_admintext.Height + top_profile.Height;

            top_image.Left = (top_leftside.Width - top_image.Width) / 2;
            top_image.Top = 10;

            top_admintext.Left = (top_leftside.Width - top_admintext.Width) / 2;
            top_admintext.Top = top_image.Bottom;

            top_profile.Left = (top_leftside.Width - top_profile.Width) / 2;
            top_profile.Top = top_admintext.Bottom;


            //Resize middle panel components in left side of maincontainer 

            tcu_mission.Font = new Font("Arial", 18, FontStyle.Bold);
            tcu_vision.Font = new Font("Arial", 18, FontStyle.Bold);
            tcu_philosophy.Font = new Font("Arial", 18, FontStyle.Bold);

            mission_statement.Font = new Font("Arial", 16, FontStyle.Regular);
            vision_statement.Font = new Font("Arial", 16, FontStyle.Regular);
            philosophy_statement.Font = new Font("Arial", 16, FontStyle.Regular);

            
            //Relocate middle panel components in left side of maincontainer 

            tcu_mission.Left = (middle_leftside.Width - tcu_mission.Width) / 2;
            tcu_mission.Top = 40;

            mission_statement.Left = (middle_leftside.Width - mission_statement.Width) / 2;
            mission_statement.Top = tcu_mission.Bottom + 10;

            tcu_vision.Left = (middle_leftside.Width - tcu_vision.Width) / 2;
            tcu_vision.Top = mission_statement.Bottom + 40;

            vision_statement.Left = (middle_leftside.Width - vision_statement.Width) / 2;
            vision_statement.Top = tcu_vision.Bottom + 10;

            tcu_philosophy.Left = (middle_leftside.Width - tcu_philosophy.Width) / 2;
            tcu_philosophy.Top = vision_statement.Bottom + 40;

            philosophy_statement.Left = (middle_leftside.Width - philosophy_statement.Width) / 2;
            philosophy_statement.Top = tcu_philosophy.Bottom + 10;



            //Resize bottom panel components in left side of maincontainer

            tcu_truth.Font = new Font("Arial", 18, FontStyle.Bold);
            tcu_competence.Font = new Font("Arial", 18, FontStyle.Bold);
            tcu_unity.Font = new Font("Arial", 18, FontStyle.Bold);

            tcu_truth.Top = 20;
            tcu_truth.Left = (int)(bottom_leftside.Width * 0.15);
            tcu_competence.Top = 20;
            tcu_competence.Left = (int)(bottom_leftside.Width * 0.35);
            tcu_unity.Top = 20;
            tcu_unity.Left = (int)(bottom_leftside.Width * 0.7);



            //Resize right side of maincontainer

            int rightwidth = (int)(maincontainer.Width * 0.6);
            int rightheight = maincontainer.Height;

            right_side.Size = new Size(rightwidth, rightheight);
            right_side.Left = (int)(maincontainer.Width * 0.40);

            //Resize top panel objects in right side of maincontainer

            top_rightside.Width = right_side.Width;
            top_rightside.Height = (int)(right_side.Height * 0.4);

            tcu_bg.Width = (int)(top_rightside.Width * 0.95);
            tcu_bg.Height = (int)(top_rightside.Height * 0.9);

            tcu_bg.Top = 20;
            tcu_bg.Left = (top_rightside.Width - tcu_bg.Width) / 2;

            //Resize bottom panel in right side of maincontainer

            bottom_rightside.Width = (int)(right_side.Width * 0.95);
            bottom_rightside.Height = (int)(right_side.Height * 0.6);

            bottom_rightside.Left = (right_side.Width - bottom_rightside.Width) / 2;
            bottom_rightside.Top = top_rightside.Bottom;

            //Resize bottom panel components buttons in right side of maincontainer


            //Calls ButtonResize() method to resize all buttons inside bottom panel

            ButtonResize(add_stud);
            ButtonResize(add_prof);
            ButtonResize(add_sub);
            ButtonResize(add_del_sec);
            ButtonResize(delete_stud);
            ButtonResize(delete_prof);
            ButtonResize(assign_sec);
            ButtonResize(assign_irreg);
            ButtonResize(assign_prof);
            ButtonResize(change_sem);


            //Relocate all buttons inside bottom panel

            add_stud.Left = 0;
            delete_stud.Left = 0;
            assign_prof.Left = 0;

            add_prof.Left = add_stud.Right + 45;
            delete_prof.Left = delete_stud.Right + 45;
            change_sem.Left = assign_prof.Right + 45;

            add_sub.Left = add_prof.Right + 45;
            assign_sec.Left = delete_prof.Right + 45;

            add_del_sec.Left = add_sub.Right + 45;
            assign_irreg.Left = assign_sec.Right + 45;

            //Top adjust between columns of buttons

            delete_stud.Top = add_stud.Bottom + 10;
            assign_prof.Top = delete_stud.Bottom + 10;

            delete_prof.Top = add_prof.Bottom + 10;
            change_sem.Top = delete_prof.Bottom + 10;

            assign_sec.Top = add_sub.Bottom + 10;
            assign_irreg.Top = add_del_sec.Bottom + 10;

            
            
            //Resize background of the forms per button

            int form_bg_width = maincontainer.Width;
            int form_bg_height = maincontainer.Height;

            form_bg.Size = new Size(form_bg_width, form_bg_height);
            form_bg.Location = new Point(0, 0);
            form_bg.Visible = false;



            //Close button at the top right corner of the form_bg

            close_button.BackColor = Color.FromArgb(203, 7, 7);
            close_button.FlatAppearance.BorderColor = Color.FromArgb(203, 7, 7);

            close_button.Left = (int)(form_bg.Width * 0.95);
            close_button.Top = 20;
            close_button.Size = new Size(50, 50);



            //Add Student Form Customize

            add_stud_form.Width = (int)(form_bg.Width * 0.5);
            add_stud_form.Height = (int)(form_bg.Height * 0.6);

            int add_stud_x = (form_bg.Width - add_stud_form.Width) / 2;
            int add_stud_y = (form_bg.Height - add_stud_form.Height) / 2;

            add_stud_form.Location = new Point(add_stud_x, add_stud_y);



            //Add Student Form Customize Content

            add_stud_header.Font = new Font("Arial", 20, FontStyle.Bold);

            add_stud_subheading.Top = add_stud_header.Bottom + 10;
            add_stud_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            add_stud_container.Top = add_stud_subheading.Bottom + 30;
            add_stud_container.Left = 30;
            add_stud_container.Size = new Size((int)(add_stud_form.Width * 0.9), (int)(add_stud_form.Width * 0.36));

            add_stud_upload.Top = (int)(add_stud_container.Height * 0.8);
            add_stud_upload.Left = 100;
            add_stud_upload.Font = new Font("Arial", 14, FontStyle.Regular);
            add_stud_upload.ForeColor = Color.FromArgb(203, 7, 7);

            add_stud_drag.Top = (int)(add_stud_container.Height * 0.8);
            add_stud_drag.Left = add_stud_upload.Right - 10;
            add_stud_drag.Font = new Font("Arial", 14, FontStyle.Regular);

            excel_pic.Top = 30;
            excel_pic.Left = (add_stud_container.Width - excel_pic.Width) / 2;

            excel_pic.Size = new Size(200, 200);



            //Add Prof Form Customize

            add_prof_form.Width = (int)(form_bg.Width * 0.5);
            add_prof_form.Height = (int)(form_bg.Height * 0.6);

            int add_prof_x = (form_bg.Width - add_prof_form.Width) / 2;
            int add_prof_y = (form_bg.Height - add_prof_form.Height) / 2;

            add_prof_form.Location = new Point(add_prof_x, add_prof_y);

            
            //Add Prof Form Customize Content

            add_prof_header.Font = new Font("Arial", 20, FontStyle.Bold);

            add_prof_subheading.Top = add_prof_header.Bottom + 10;
            add_prof_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            add_prof_container.Top = add_prof_subheading.Bottom + 30;
            add_prof_container.Left = 30;
            add_prof_container.Size = new Size((int)(add_prof_form.Width * 0.9), (int)(add_prof_form.Width * 0.36));

            add_prof_upload.Top = (int)(add_prof_container.Height * 0.8);
            add_prof_upload.Left = 100;
            add_prof_upload.Font = new Font("Arial", 14, FontStyle.Regular);
            add_prof_upload.ForeColor = Color.FromArgb(203, 7, 7);

            add_prof_drag.Top = (int)(add_prof_container.Height * 0.8);
            add_prof_drag.Left = add_prof_upload.Right - 10;
            add_prof_drag.Font = new Font("Arial", 14, FontStyle.Regular);

            add_prof_excel.Top = 30;
            add_prof_excel.Left = (add_prof_container.Width - add_prof_excel.Width) / 2;

            add_prof_excel.Size = new Size(200, 200);



            //Add Sub Form Customize

            add_sub_form.Width = (int)(form_bg.Width * 0.5);
            add_sub_form.Height = (int)(form_bg.Height * 0.6);

            int add_sub_x = (form_bg.Width - add_sub_form.Width) / 2;
            int add_sub_y = (form_bg.Height - add_sub_form.Height) / 2;

            add_sub_form.Location = new Point(add_stud_x, add_stud_y);

            //Add Sub Form Customize Content

            add_sub_header.Font = new Font("Arial", 20, FontStyle.Bold);

            add_sub_subheading.Top = add_sub_header.Bottom + 10;
            add_sub_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            add_sub_container.Top = add_sub_subheading.Bottom + 30;
            add_sub_container.Left = 30;
            add_sub_container.Size = new Size((int)(add_sub_form.Width * 0.9), (int)(add_sub_form.Width * 0.36));

            add_sub_upload.Top = (int)(add_sub_container.Height * 0.8);
            add_sub_upload.Left = 100;
            add_sub_upload.Font = new Font("Arial", 14, FontStyle.Regular);
            add_sub_upload.ForeColor = Color.FromArgb(203, 7, 7);

            add_sub_drag.Top = (int)(add_sub_container.Height * 0.8);
            add_sub_drag.Left = add_sub_upload.Right - 10;
            add_sub_drag.Font = new Font("Arial", 14, FontStyle.Regular);

            add_sub_excel.Top = 10;
            add_sub_excel.Left = (add_sub_container.Width - add_sub_excel.Width) / 2;

            add_sub_excel.Size = new Size(200, 200);


            
            //Add Sec Form Customize

            add_del_section.Width = (int)(form_bg.Width * 0.5);
            add_del_section.Height = (int)(form_bg.Height * 0.9);

            int add_del_sec_x = (form_bg.Width - add_del_section.Width) / 2;
            int add_del_sec_y = 40;

            add_del_section.Location = new Point(add_del_sec_x, add_del_sec_y);

            add_sec_form.Width = add_del_section.Width;
            add_sec_form.Height = (int)(add_del_section.Height * 0.6);

            int add_sec_x = 0;
            int add_sec_y = 0;

            add_sec_form.Location = new Point(add_sec_x, add_sec_y);

            
            //Add Sec Form Customize Content

            add_sec_header.Font = new Font("Arial", 20, FontStyle.Bold);

            add_sec_subheading.Top = add_sec_header.Bottom + 10;
            add_sec_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            add_sec_container.Top = add_sec_subheading.Bottom + 30;
            add_sec_container.Left = 30;
            add_sec_container.Size = new Size((int)(add_sec_form.Width * 0.9), (int)(add_sec_form.Height * 0.6));

            add_sec_upload.Top = (int)(add_sec_container.Height * 0.8);
            add_sec_upload.Left = 100;
            add_sec_upload.Font = new Font("Arial", 14, FontStyle.Regular);
            add_sec_upload.ForeColor = Color.FromArgb(203, 7, 7);

            add_sec_drag.Top = (int)(add_sec_container.Height * 0.8);
            add_sec_drag.Left = add_sec_upload.Right - 10;
            add_sec_drag.Font = new Font("Arial", 14, FontStyle.Regular);

            add_sec_excel.Top = 30;
            add_sec_excel.Left = (add_sec_container.Width - add_sec_excel.Width) / 2;

            add_sec_excel.Size = new Size(200, 200);

            delete_sec_form.Width = add_del_section.Width;
            delete_sec_form.Height = (int)(add_del_section.Height * 0.35);

            int delete_sec_x = 0;
            int delete_sec_y = add_sec_form.Bottom + 30;

            delete_sec_form.Location = new Point(delete_sec_x, delete_sec_y);

            delete_sec_header.Font = new Font("Arial", 20, FontStyle.Bold);

            delete_sec_subheading.Top = delete_sec_header.Bottom + 10;
            delete_sec_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            delete_sec_searchbar.Top = delete_sec_subheading.Bottom + 15;
            delete_sec_searchbar.Height = 40;
            delete_sec_searchbar.Font = new Font("Arial", 12, FontStyle.Regular);

            delete_sec_searchresults.Top = delete_sec_searchbar.Bottom;

            delete_sec_searchresults.Visible = false;

            delete_sec_deletebtn.BackColor = Color.FromArgb(203, 7, 7);
            delete_sec_deletebtn.Size = new Size(180, 90);
            delete_sec_deletebtn.Font = new Font("Arial", 14, FontStyle.Bold);
            delete_sec_deletebtn.Left = (int)(delete_sec_form.Width * 0.77);



            //Delete Batch Students Form Customize

            del_batchstud_form.Width = (int)(form_bg.Width * 0.5);
            del_batchstud_form.Height = (int)(form_bg.Height * 0.38);

            int del_batchstud_x = (form_bg.Width - del_batchstud_form.Width) / 2;
            int del_batchstud_y = (form_bg.Height - del_batchstud_form.Height) / 2;

            del_batchstud_form.Location = new Point(add_stud_x, add_stud_y);

            //Delete Batch Students Form Customize Content

            del_batchstud_header.Font = new Font("Arial", 20, FontStyle.Bold);

            del_batchstud_subheading.Top = del_batchstud_header.Bottom + 10;
            del_batchstud_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            del_batchstud_search.Top = del_batchstud_subheading.Bottom + 30;
            del_batchstud_search.Height = 40;
            del_batchstud_search.Font = new Font("Arial", 12, FontStyle.Regular);

            del_batchstud_searchresults.Top = del_batchstud_search.Bottom;

            del_batchstud_searchresults.Visible = false;

            del_batchstud_deletebtn.BackColor = Color.FromArgb(203, 7, 7);
            del_batchstud_deletebtn.Size = new Size(180, 90);
            del_batchstud_deletebtn.Font = new Font("Arial", 14, FontStyle.Bold);
            del_batchstud_deletebtn.Left = (int)(delete_sec_form.Width * 0.77);




            //Delete Prof Form Customize

            del_prof_form.Width = (int)(form_bg.Width * 0.5);
            del_prof_form.Height = (int)(form_bg.Height * 0.38);

            int del_prof_x = (form_bg.Width - del_prof_form.Width) / 2;
            int del_prof_y = (form_bg.Height - del_prof_form.Height) / 2;

            del_prof_form.Location = new Point(add_stud_x, add_stud_y);

            //Delete Prof Form Customize Content

            del_prof_header.Font = new Font("Arial", 20, FontStyle.Bold);

            del_prof_subheading.Top = del_prof_header.Bottom + 10;
            del_prof_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            del_prof_text.Font = new Font("Arial", 14, FontStyle.Regular);
            del_prof_text.Top = del_prof_subheading.Bottom + 10;

            del_prof_search.Top = del_prof_text.Bottom + 30;
            del_prof_search.Height = 40;
            del_prof_search.Font = new Font("Arial", 12, FontStyle.Regular);

            del_prof_searchresults.Top = del_batchstud_search.Bottom;

            del_prof_searchresults.Visible = false;

            del_prof_deletebtn.BackColor = Color.FromArgb(203, 7, 7);
            del_prof_deletebtn.Size = new Size(180, 90);
            del_prof_deletebtn.Font = new Font("Arial", 14, FontStyle.Bold);
            del_prof_deletebtn.Left = (int)(delete_sec_form.Width * 0.77);



            //Assign Sub to Section Customize

            unassign_assign_subtosec.Width = (int)(form_bg.Width * 0.5);
            unassign_assign_subtosec.Height = form_bg.Height;

            int unassign_assign_x = (form_bg.Width - unassign_assign_subtosec.Width) / 2;
            int unassign_assign_y = 80;

            unassign_assign_subtosec.Location = new Point(unassign_assign_x, unassign_assign_y);

            assign_subtosec_form.Width = unassign_assign_subtosec.Width;
            assign_subtosec_form.Height = (int)(unassign_assign_subtosec.Height * 0.4);

            int assign_subtosec_form_x = 0;
            int assign_subtosec_form_y = 0;

            assign_subtosec_form.Location = new Point(assign_subtosec_form_x, assign_subtosec_form_y);

            //Assign Sub to Section Customize Content

            assign_subtosec_header.Font = new Font("Arial", 16, FontStyle.Bold);

            assign_subtosec_subheading.Top = assign_subtosec_header.Bottom + 10;
            assign_subtosec_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            assign_subtosec_container.Top = assign_subtosec_subheading.Bottom + 20;
            assign_subtosec_container.Left = 35;
            assign_subtosec_container.Size = new Size((int)(assign_subtosec_form.Width * 0.9), (int)(assign_subtosec_form.Height * 0.6));

            assign_subtosec_upload.Top = (int)(assign_subtosec_container.Height * 0.8);
            assign_subtosec_upload.Left = 100;
            assign_subtosec_upload.Font = new Font("Arial", 14, FontStyle.Regular);
            assign_subtosec_upload.ForeColor = Color.FromArgb(203, 7, 7);

            assign_subtosec_drag.Top = (int)(assign_subtosec_container.Height * 0.8);
            assign_subtosec_drag.Left = assign_subtosec_upload.Right - 10;
            assign_subtosec_drag.Font = new Font("Arial", 14, FontStyle.Regular);

            assign_subtosec_excel.Top = 10;
            assign_subtosec_excel.Left = (assign_subtosec_container.Width - assign_subtosec_excel.Width) / 2;

            assign_subtosec_excel.Size = new Size(120, 120);




            //Unassign Sub to Section Customize

            unassign_subtosec_form.Width = unassign_assign_subtosec.Width;
            unassign_subtosec_form.Height = (int)(unassign_assign_subtosec.Height * 0.4);

            int unassign_subtosec_form_x = 0;
            int unassign_subtosec_form_y = assign_subtosec_form.Bottom + 40;

            unassign_subtosec_form.Location = new Point(unassign_subtosec_form_x, unassign_subtosec_form_y);



            //Unassign Sub to Section Customize Content

            unassign_subtosec_header.Font = new Font("Arial", 16, FontStyle.Bold);

            unassign_subtosec_subheading.Top = unassign_subtosec_header.Bottom + 10;
            unassign_subtosec_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            unassign_subtosec_container.Top = unassign_subtosec_subheading.Bottom + 20;
            unassign_subtosec_container.Left = 35;
            unassign_subtosec_container.Size = new Size((int)(unassign_subtosec_form.Width * 0.9), (int)(unassign_subtosec_form.Height * 0.6));

            unassign_subtosec_upload.Top = (int)(unassign_subtosec_container.Height * 0.8);
            unassign_subtosec_upload.Left = 100;
            unassign_subtosec_upload.Font = new Font("Arial", 14, FontStyle.Regular);
            unassign_subtosec_upload.ForeColor = Color.FromArgb(203, 7, 7);

            unassign_subtosec_drag.Top = (int)(unassign_subtosec_container.Height * 0.8);
            unassign_subtosec_drag.Left = unassign_subtosec_upload.Right - 10;
            unassign_subtosec_drag.Font = new Font("Arial", 14, FontStyle.Regular);

            unassign_subtosec_excel.Top = 10;
            unassign_subtosec_excel.Left = (unassign_subtosec_container.Width - unassign_subtosec_excel.Width) / 2;

            unassign_subtosec_excel.Size = new Size(120, 120);



            //Assign Sub to Irreg Customize
            unassign_assign_subtoirreg.Width = (int)(form_bg.Width * 0.5);
            unassign_assign_subtoirreg.Height = form_bg.Height;

            int unassign_assign_subtoirreg_x = (form_bg.Width - unassign_assign_subtoirreg.Width) / 2;
            int unassign_assign_subtoirreg_y = 80;

            unassign_assign_subtoirreg.Location = new Point(unassign_assign_subtoirreg_x, unassign_assign_subtoirreg_y);

            assign_subtoirreg_form.Width = unassign_assign_subtoirreg.Width;
            assign_subtoirreg_form.Height = (int)(unassign_assign_subtoirreg.Height * 0.4);

            int assign_subtoirreg_form_x = 0;
            int assign_subtoirreg_form_y = 0;

            assign_subtoirreg_form.Location = new Point(assign_subtoirreg_form_x, assign_subtoirreg_form_y);

            //Assign Sub to Irreg Customize Content

            assign_subtoirreg_header.Font = new Font("Arial", 16, FontStyle.Bold);

            assign_subtoirreg_subheading.Top = assign_subtoirreg_header.Bottom + 10;
            assign_subtoirreg_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            assign_subtoirreg_container.Top = assign_subtoirreg_subheading.Bottom + 20;
            assign_subtoirreg_container.Left = 35;
            assign_subtoirreg_container.Size = new Size((int)(assign_subtoirreg_form.Width * 0.9), (int)(assign_subtoirreg_form.Height * 0.6));


            assign_subtoirreg_upload.Top = (int)(assign_subtoirreg_container.Height * 0.8);
            assign_subtoirreg_upload.Left = 100;
            assign_subtoirreg_upload.Font = new Font("Arial", 14, FontStyle.Regular);
            assign_subtoirreg_upload.ForeColor = Color.FromArgb(203, 7, 7);

            assign_subtoirreg_drag.Top = (int)(assign_subtoirreg_container.Height * 0.8);
            assign_subtoirreg_drag.Left = assign_subtoirreg_upload.Right - 10;
            assign_subtoirreg_drag.Font = new Font("Arial", 14, FontStyle.Regular);

            assign_subtoirreg_excel.Top = 10;
            assign_subtoirreg_excel.Left = (assign_subtoirreg_container.Width - assign_subtoirreg_excel.Width) / 2;

            assign_subtoirreg_excel.Size = new Size(120, 120);




            //Unassign Sub to Irreg Customize

            unassign_subtoirreg_form.Width = unassign_assign_subtoirreg.Width;
            unassign_subtoirreg_form.Height = (int)(unassign_assign_subtoirreg.Height * 0.4);

            int unassign_subtoirreg_form_x = 0;
            int unassign_subtoirreg_form_y = assign_subtoirreg_form.Bottom + 40;

            unassign_subtoirreg_form.Location = new Point(unassign_subtoirreg_form_x, unassign_subtoirreg_form_y);



            //Unassign Sub to Irreg Customize Content

            unassign_subtoirreg_header.Font = new Font("Arial", 16, FontStyle.Bold);

            unassign_subtoirreg_subheading.Top = unassign_subtoirreg_header.Bottom + 10;
            unassign_subtoirreg_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            unassign_subtoirreg_container.Top = unassign_subtoirreg_subheading.Bottom + 20;
            unassign_subtoirreg_container.Left = 35;
            unassign_subtoirreg_container.Size = new Size((int)(unassign_subtoirreg_form.Width * 0.9), (int)(unassign_subtoirreg_form.Height * 0.6));

            unassign_subtoirreg_upload.Top = (int)(unassign_subtoirreg_container.Height * 0.8);
            unassign_subtoirreg_upload.Left = 100;
            unassign_subtoirreg_upload.Font = new Font("Arial", 14, FontStyle.Regular);
            unassign_subtoirreg_upload.ForeColor = Color.FromArgb(203, 7, 7);

            unassign_subtoirreg_drag.Top = (int)(unassign_subtoirreg_container.Height * 0.8);
            unassign_subtoirreg_drag.Left = unassign_subtoirreg_upload.Right - 10;
            unassign_subtoirreg_drag.Font = new Font("Arial", 14, FontStyle.Regular);

            unassign_subtoirreg_excel.Top = 10;
            unassign_subtoirreg_excel.Left = (unassign_subtoirreg_container.Width - unassign_subtoirreg_excel.Width) / 2;

            unassign_subtoirreg_excel.Size = new Size(120, 120);



            //Assign Sub to Prof Customize
            unassign_assign_subtoprof.Width = (int)(form_bg.Width * 0.5);
            unassign_assign_subtoprof.Height = form_bg.Height;

            int unassign_assign_subtoprof_x = (form_bg.Width - unassign_assign_subtoprof.Width) / 2;
            int unassign_assign_subtoprof_y = 80;

            unassign_assign_subtoprof.Location = new Point(unassign_assign_subtoprof_x, unassign_assign_subtoprof_y);

            assign_subtoprof_form.Width = unassign_assign_subtoprof.Width;
            assign_subtoprof_form.Height = (int)(unassign_assign_subtoprof.Height * 0.4);

            int assign_subtoprof_x = 0;
            int assign_subtoprof_y = 0;

            assign_subtoprof_form.Location = new Point(assign_subtoprof_x, assign_subtoprof_y);

            //Assign Sub to Prof Customize Content

            assign_subtoprof_header.Font = new Font("Arial", 16, FontStyle.Bold);

            assign_subtoprof_subheading.Top = assign_subtoprof_header.Bottom + 10;
            assign_subtoprof_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            assign_subtoprof_container.Top = assign_subtoprof_subheading.Bottom + 20;
            assign_subtoprof_container.Left = 35;
            assign_subtoprof_container.Size = new Size((int)(assign_subtoprof_form.Width * 0.9), (int)(assign_subtoprof_form.Height * 0.6));


            assign_subtoprof_upload.Top = (int)(assign_subtoprof_container.Height * 0.8);
            assign_subtoprof_upload.Left = 100;
            assign_subtoprof_upload.Font = new Font("Arial", 14, FontStyle.Regular);
            assign_subtoprof_upload.ForeColor = Color.FromArgb(203, 7, 7);

            assign_subtoprof_drag.Top = (int)(assign_subtoprof_container.Height * 0.8);
            assign_subtoprof_drag.Left = assign_subtoprof_upload.Right - 10;
            assign_subtoprof_drag.Font = new Font("Arial", 14, FontStyle.Regular);

            assign_subtoprof_excel.Top = 10;
            assign_subtoprof_excel.Left = (assign_subtoprof_container.Width - assign_subtoprof_excel.Width) / 2;

            assign_subtoprof_excel.Size = new Size(120, 120);




            //Unassign Sub to Prof Customize

            unassign_subtoprof_form.Width = unassign_assign_subtoprof.Width;
            unassign_subtoprof_form.Height = (int)(unassign_assign_subtoprof.Height * 0.4);

            int unassign_subtoprof_form_x = 0;
            int unassign_subtoprof_form_y = assign_subtoprof_form.Bottom + 40;

            unassign_subtoprof_form.Location = new Point(unassign_subtoprof_form_x, unassign_subtoprof_form_y);



            //Unassign Sub to Prof Customize Content

            unassign_subtoprof_header.Font = new Font("Arial", 16, FontStyle.Bold);

            unassign_subtoprof_subheading.Top = unassign_subtoprof_header.Bottom + 10;
            unassign_subtoprof_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            unassign_subtoprof_container.Top = unassign_subtoprof_subheading.Bottom + 20;
            unassign_subtoprof_container.Left = 35;
            unassign_subtoprof_container.Size = new Size((int)(unassign_subtoprof_form.Width * 0.9), (int)(unassign_subtoprof_form.Height * 0.6));

            unassign_subtoprof_upload.Top = (int)(unassign_subtoprof_container.Height * 0.8);
            unassign_subtoprof_upload.Left = 100;
            unassign_subtoprof_upload.Font = new Font("Arial", 14, FontStyle.Regular);
            unassign_subtoprof_upload.ForeColor = Color.FromArgb(203, 7, 7);

            unassign_subtoprof_drag.Top = (int)(unassign_subtoprof_container.Height * 0.8);
            unassign_subtoprof_drag.Left = unassign_subtoprof_upload.Right - 10;
            unassign_subtoprof_drag.Font = new Font("Arial", 14, FontStyle.Regular);

            unassign_subtoprof_excel.Top = 10;
            unassign_subtoprof_excel.Left = (unassign_subtoprof_container.Width - unassign_subtoprof_excel.Width) / 2;

            unassign_subtoprof_excel.Size = new Size(120, 120);



            //Change Sem Form Customize

            change_sem_form.Width = (int)(form_bg.Width * 0.5);
            change_sem_form.Height = (int)(form_bg.Height * 0.38);

            int change_sem_x = (form_bg.Width - change_sem_form.Width) / 2;
            int change_sem_y = (form_bg.Height - change_sem_form.Height) / 2;

            change_sem_form.Location = new Point(change_sem_x, change_sem_y);

            //Change Sem Form Customize Content

            change_sem_header.Font = new Font("Arial", 20, FontStyle.Bold);

            change_sem_subheading.Top = change_sem_header.Bottom + 10;
            change_sem_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            change_sem_search.Top = change_sem_subheading.Bottom + 30;
            change_sem_search.Height = 40;
            change_sem_search.Font = new Font("Arial", 12, FontStyle.Regular);

            change_sem_searchresults.Top = change_sem_search.Bottom;

            change_sem_searchresults.Visible = false;

            change_sem_changebtn.BackColor = Color.FromArgb(203, 7, 7);
            change_sem_changebtn.Size = new Size(180, 90);
            change_sem_changebtn.Font = new Font("Arial", 14, FontStyle.Bold);
            change_sem_changebtn.Left = (int)(change_sem_form.Width * 0.77);




            //Dropdown Menu Customize

            dropdownmenu.Visible = false;

            dropdownmenu.Width = (int)(body.Width * 0.25);
            dropdownmenu.Height = body.Height;

            //Dropdown Menu Customize Logo

            dropdown_head_logo.Size = new Size(200, 200);
            dropdown_head_logo.Top = dropdownmenu.Top + 50;
            dropdown_head_logo.Left = (dropdownmenu.Width - dropdown_head_logo.Width) / 2;

            //Dropdown Menu Customize Close Button

            dropdown_closebtn.BackColor = Color.FromArgb(203, 7, 7);
            dropdown_closebtn.FlatAppearance.BorderColor = Color.FromArgb(203, 7, 7);

            dropdown_closebtn.Left = (int)(dropdownmenu.Width * 0.85);
            dropdown_closebtn.Top = dropdownmenu.Top + 20;
            dropdown_closebtn.Size = new Size(50, 50);

            //Dropdown Menu Customize Navigations and Resize each including panels, labels, and picturebox

            CustomizeDropdownNavs(dashboard_panel, dashboard_text, dashboard_icon);
            CustomizeDropdownNavs(students_panel, students_text, student_icon);
            CustomizeDropdownNavs(sections_panel, sections_text, section_icon);
            CustomizeDropdownNavs(gradecriteria_panel, gradecriteria_text, grade_icon);
            CustomizeDropdownNavs(logout_panel, logout_text, logout_icon);


            //Relocate navigations

            dashboard_panel.Top = dropdown_head_logo.Bottom + 30;
            students_panel.Top = dashboard_panel.Bottom + 20;
            sections_panel.Top = students_panel.Bottom + 20;
            gradecriteria_panel.Top = sections_panel.Bottom + 20;
            logout_panel.Top = gradecriteria_panel.Bottom + 25;

            
            //Customize Table for Grading Criteria and Relocate

            gradingcriteria_table.Visible = false;

            int gradingcriteria_width = (int)(form_bg.Width * 0.7);
            int gradingcriteria_height = (int)(form_bg.Height * 0.78);

            gradingcriteria_table.Size = new Size(gradingcriteria_width, gradingcriteria_height);

            int gradingcriteria_x = (form_bg.Width - gradingcriteria_width) / 2;

            gradingcriteria_table.Location = new Point(gradingcriteria_x, (int)(form_bg.Height * 0.2));

            //Add rows

            gradingcriteria_table.Rows.Add("98-100", "1.00");
            gradingcriteria_table.Rows.Add("95-97", "1.25");
            gradingcriteria_table.Rows.Add("92-94", "1.50");
            gradingcriteria_table.Rows.Add("89-91", "1.75");
            gradingcriteria_table.Rows.Add("86-88", "2.00");
            gradingcriteria_table.Rows.Add("83-85", "2.25");
            gradingcriteria_table.Rows.Add("80-82", "2.50");
            gradingcriteria_table.Rows.Add("77-79", "2.75");
            gradingcriteria_table.Rows.Add("75-76", "3.00");
            gradingcriteria_table.Rows.Add("74 Below", "5.00");

            gradingcriteria_table.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 20, FontStyle.Bold);

            //Customize Table Header- Grading Criteria

            gradingcriteria_header.Font = new Font("Arial", 30, FontStyle.Bold);

            gradingcriteria_header.Location = new Point((form_bg.Width - gradingcriteria_header.Width) / 2, (int)(form_bg.Height * 0.08));

            //Resize the height of rows depending on the current height of the table

            int available_height = (gradingcriteria_height - gradingcriteria_table.ColumnHeadersHeight);

            int row_height = available_height / gradingcriteria_table.Rows.Count;


            //Manually adjusting the height based on the value of available height and number of rows to be adjusted

            gradingcriteria_table.RowTemplate.Height = row_height;

            //Adjust all of the rows

            foreach (DataGridViewRow row in gradingcriteria_table.Rows)
            {
                row.Height = row_height;
            }

            //Remove columns arrows in sorting rows

            foreach (DataGridViewColumn column in gradingcriteria_table.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //Function to remove borders of the buttons 

            hoverButtons(add_stud);
            hoverButtons(add_prof);
            hoverButtons(add_sub);
            hoverButtons(add_del_sec);
            hoverButtons(delete_stud);
            hoverButtons(delete_prof);
            hoverButtons(assign_sec);
            hoverButtons(assign_irreg);
            hoverButtons(assign_prof);
            hoverButtons(change_sem);
            hoverButtons(close_button);
            hoverButtons(dropdown_closebtn);
            hoverButtons(change_sem_changebtn);
            hoverButtons(delete_sec_deletebtn);
            hoverButtons(del_prof_deletebtn);
            hoverButtons(del_batchstud_deletebtn);


            //Function to underline upload text when hover and goes back to original when not hover

            hoverUploadLabel(add_stud_upload);
            hoverUploadLabel(add_prof_upload);
            hoverUploadLabel(add_sub_upload);
            hoverUploadLabel(add_sec_upload);
            hoverUploadLabel(assign_subtosec_upload);
            hoverUploadLabel(unassign_subtosec_upload);
            hoverUploadLabel(assign_subtoirreg_upload);
            hoverUploadLabel(unassign_subtoirreg_upload);
            hoverUploadLabel(assign_subtoprof_upload);
            hoverUploadLabel(unassign_subtoprof_upload);


            //Function to apply a custom border weight and dashed border for the uploads

            ApplyCustomBorder(add_stud_form);
            ApplyDashedBorder(add_stud_container);

            ApplyCustomBorder(add_prof_form);
            ApplyDashedBorder(add_prof_container);

            ApplyCustomBorder(add_sub_form);
            ApplyDashedBorder(add_sub_container);

            ApplyCustomBorder(add_sec_form);
            ApplyCustomBorder(delete_sec_form);
            ApplyDashedBorder(add_sec_container);
            

            ApplyCustomBorder(del_batchstud_form);

            ApplyCustomBorder(del_prof_form);

            ApplyCustomBorder(assign_subtosec_form);
            ApplyCustomBorder(unassign_subtosec_form);
            ApplyDashedBorder(assign_subtosec_container);
            ApplyDashedBorder(unassign_subtosec_container);

            ApplyCustomBorder(assign_subtoirreg_form);
            ApplyCustomBorder(unassign_subtoirreg_form);
            ApplyDashedBorder(assign_subtoirreg_container);
            ApplyDashedBorder(unassign_subtoirreg_container);

            ApplyCustomBorder(assign_subtoprof_form);
            ApplyCustomBorder(unassign_subtoprof_form);
            ApplyDashedBorder(assign_subtoprof_container);
            ApplyDashedBorder(unassign_subtoprof_container);

            ApplyCustomBorder(change_sem_form);


        }

        private void dropdownmenu_Paint(object sender, PaintEventArgs e)
        {
            dropdownmenu.BackColor = Color.FromArgb(255, 102, 102);
        }


        private void delete_stud_Click(object sender, EventArgs e)
        {
            form_bg.Visible = true;
            add_prof_form.Visible = false;
            add_stud_form.Visible = false;
            add_sub_form.Visible = false;
            add_del_section.Visible = false;
            del_batchstud_form.Visible = true;
            del_prof_form.Visible = false;
            unassign_assign_subtosec.Visible = false;
            unassign_assign_subtoirreg.Visible = false;
            unassign_assign_subtoprof.Visible = false;
            change_sem_form.Visible = false;
            gradingcriteria_header.Visible = false;
            gradingcriteria_table.Visible = false;
        }

        private void add_stud_Click(object sender, EventArgs e)
        {
            form_bg.Visible = true;
            add_prof_form.Visible = false;
            add_stud_form.Visible = true;
            add_sub_form.Visible = false;
            add_del_section.Visible = false;
            del_batchstud_form.Visible = false;
            del_prof_form.Visible = false;
            unassign_assign_subtosec.Visible = false;
            unassign_assign_subtoirreg.Visible = false;
            unassign_assign_subtoprof.Visible = false;
            change_sem_form.Visible = false;
            gradingcriteria_header.Visible = false;
            gradingcriteria_table.Visible = false;

        }

        private void add_prof_Click(object sender, EventArgs e)
        {
            form_bg.Visible = true;
            add_stud_form.Visible = false;
            add_prof_form.Visible = true;
            add_sub_form.Visible = false;
            add_del_section.Visible = false;
            del_batchstud_form.Visible = false;
            del_prof_form.Visible = false;
            unassign_assign_subtosec.Visible = false;
            unassign_assign_subtoirreg.Visible = false;
            unassign_assign_subtoprof.Visible = false;
            change_sem_form.Visible = false;
            gradingcriteria_header.Visible = false;
            gradingcriteria_table.Visible = false;
        }


        private void add_sub_Click(object sender, EventArgs e)
        {
            form_bg.Visible = true;
            add_stud_form.Visible = false;
            add_prof_form.Visible = false;
            add_sub_form.Visible = true;
            add_del_section.Visible = false;
            del_batchstud_form.Visible = false;
            del_prof_form.Visible = false;
            unassign_assign_subtosec.Visible = false;
            unassign_assign_subtoirreg.Visible = false;
            unassign_assign_subtoprof.Visible = false;
            change_sem_form.Visible = false;
            gradingcriteria_header.Visible = false;
            gradingcriteria_table.Visible = false;
        }

        private void add_del_sec_Click(object sender, EventArgs e)
        {
            form_bg.Visible = true;
            add_stud_form.Visible = false;
            add_prof_form.Visible = false;
            add_sub_form.Visible = false;
            add_del_section.Visible = true;
            del_batchstud_form.Visible = false;
            del_prof_form.Visible = false;
            unassign_assign_subtosec.Visible = false;
            unassign_assign_subtoirreg.Visible = false;
            unassign_assign_subtoprof.Visible = false;
            change_sem_form.Visible = false;
            gradingcriteria_header.Visible = false;
            gradingcriteria_table.Visible = false;
        }


        private void delete_prof_Click(object sender, EventArgs e)
        {
            form_bg.Visible = true;
            add_stud_form.Visible = false;
            add_prof_form.Visible = false;
            add_sub_form.Visible = false;
            add_del_section.Visible = false;
            del_batchstud_form.Visible = false;
            del_prof_form.Visible = true;
            unassign_assign_subtosec.Visible = false;
            unassign_assign_subtoirreg.Visible = false;
            unassign_assign_subtoprof.Visible = false;
            change_sem_form.Visible = false;
            gradingcriteria_header.Visible = false;
            gradingcriteria_table.Visible = false;
        }

        private void assign_sec_Click(object sender, EventArgs e)
        {
            form_bg.Visible = true;
            add_stud_form.Visible = false;
            add_prof_form.Visible = false;
            add_sub_form.Visible = false;
            add_del_section.Visible = false;
            del_batchstud_form.Visible = false;
            del_prof_form.Visible = false;
            unassign_assign_subtosec.Visible = true;
            unassign_assign_subtoirreg.Visible = false;
            unassign_assign_subtoprof.Visible = false;
            change_sem_form.Visible = false;
            gradingcriteria_header.Visible = false;
            gradingcriteria_table.Visible = false;
        }

        private void assign_irreg_Click(object sender, EventArgs e)
        {
            form_bg.Visible = true;
            add_stud_form.Visible = false;
            add_prof_form.Visible = false;
            add_sub_form.Visible = false;
            add_del_section.Visible = false;
            del_batchstud_form.Visible = false;
            del_prof_form.Visible = false;
            unassign_assign_subtosec.Visible = false;
            unassign_assign_subtoirreg.Visible = true;
            unassign_assign_subtoprof.Visible = false;
            change_sem_form.Visible = false;
            gradingcriteria_header.Visible = false;
            gradingcriteria_table.Visible = false;
        }

        private void assign_prof_Click(object sender, EventArgs e)
        {
            form_bg.Visible = true;
            add_stud_form.Visible = false;
            add_prof_form.Visible = false;
            add_sub_form.Visible = false;
            add_del_section.Visible = false;
            del_batchstud_form.Visible = false;
            del_prof_form.Visible = false;
            unassign_assign_subtosec.Visible = false;
            unassign_assign_subtoirreg.Visible = false;
            unassign_assign_subtoprof.Visible = true;
            change_sem_form.Visible = false;
            gradingcriteria_header.Visible = false;
            gradingcriteria_table.Visible = false;
        }

        private void change_sem_Click(object sender, EventArgs e)
        {
            form_bg.Visible = true;
            add_stud_form.Visible = false;
            add_prof_form.Visible = false;
            add_sub_form.Visible = false;
            add_del_section.Visible = false;
            del_batchstud_form.Visible = false;
            del_prof_form.Visible = false;
            unassign_assign_subtosec.Visible = false;
            unassign_assign_subtoirreg.Visible = false;
            unassign_assign_subtoprof.Visible = false;
            change_sem_form.Visible = true;
            gradingcriteria_header.Visible = false;
            gradingcriteria_table.Visible = false;
        }

        private void gradecriteria_text_Click(object sender, EventArgs e)
        {
            form_bg.Visible = true;
            add_stud_form.Visible = false;
            add_prof_form.Visible = false;
            add_sub_form.Visible = false;
            add_del_section.Visible = false;
            del_batchstud_form.Visible = false;
            del_prof_form.Visible = false;
            unassign_assign_subtosec.Visible = false;
            unassign_assign_subtoirreg.Visible = false;
            unassign_assign_subtoprof.Visible = false;
            change_sem_form.Visible = false;
            gradingcriteria_header.Visible = true;
            gradingcriteria_table.Visible = true;



        }

        private void gradecriteria_panel_Paint(object sender, PaintEventArgs e)
        {
            gradecriteria_panel.MouseClick += (s, e) => form_bg.Visible = true;
            add_stud_form.Visible = false;
            add_prof_form.Visible = false;
            add_sub_form.Visible = false;
            add_del_section.Visible = false;
            del_batchstud_form.Visible = false;
            del_prof_form.Visible = false;
            unassign_assign_subtosec.Visible = false;
            unassign_assign_subtoirreg.Visible = false;
            unassign_assign_subtoprof.Visible = false;
            change_sem_form.Visible = false;
            gradingcriteria_table.Visible = true;
            gradingcriteria_header.Visible = true;

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            form_bg.Visible = false;

        }

        private void menu_Click(object sender, EventArgs e)
        {
            dropdownmenu.Visible = true;
        }

        private void dropdown_closebtn_Click(object sender, EventArgs e)
        {
            dropdownmenu.Visible = false;
        }


        private void add_stud_upload_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void add_prof_upload_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void add_sub_upload_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void add_sec_upload_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void assign_subtosec_upload_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void unassign_subtosec_upload_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void assign_subtoirreg_upload_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void unassign_subtoirreg_upload_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void assign_subtoprof_upload_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void unassign_subtoprof_upload_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void ButtonResize(Button button)
        {
            button.BackColor = Color.FromArgb(203, 7, 7);
            button.ForeColor = Color.White;
            button.Font = new Font("Arial", 14, FontStyle.Regular);
            button.Size = new Size(240, 160);
        }
        private void CustomizeDropdownNavs(Panel panel, System.Windows.Forms.Label labels, PictureBox picture)
        {
            int width = dropdownmenu.Width;
            int height = (int)(dropdownmenu.Height * 0.13);

            

            panel.Size = new Size(width, height);
            labels.Font = new Font("Arial", 18, FontStyle.Regular);

            panel.Cursor = Cursors.Hand;
            labels.Cursor= Cursors.Hand;
           
            panel.BackColor = Color.Transparent;

            picture.Size = new Size(80, 80);
            picture.Left = (int)(panel.Width * 0.05);
            picture.Top = (panel.Height - picture.Height) / 2;

            labels.Left = picture.Right + 10;
            labels.Top = (panel.Height - labels.Height) / 2;

            panel.MouseEnter += (s, e) => panel.BackColor = Color.FromArgb(220, 50, 50); labels.ForeColor = Color.White; labels.Font = new Font(labels.Font, FontStyle.Bold);
            labels.MouseEnter += (s, e) => panel.BackColor = Color.FromArgb(220, 50, 50);
            panel.MouseLeave += (s, e) => panel.BackColor = Color.Transparent; labels.ForeColor = Color.White; labels.Font = new Font(labels.Font, FontStyle.Regular);

        }

        private void hoverButtons(Button button)
        {
            button.Cursor = Cursors.Hand;
            button.TabStop = false;  
            button.FlatStyle = FlatStyle.Flat;  
            button.FlatAppearance.BorderSize = 0;
        }

        private void hoverUploadLabel(System.Windows.Forms.Label label)
        {
            label.MouseEnter += (s,e)=> label.Font= new Font(label.Font, FontStyle.Underline);
            label.MouseLeave += (s, e) => label.Font = new Font(label.Font, FontStyle.Regular);

            label.Cursor = Cursors.Hand;
        }

        private void ApplyCustomBorder(Panel panel)
        {
            panel.BorderStyle = BorderStyle.None;

            panel.Paint += (sender, e)=>{

                Color borderColor = Color.Black;
                int borderThickness = 5;

                using (Pen borderPen = new Pen(borderColor, borderThickness))
                {
                    e.Graphics.DrawRectangle(borderPen, 0, 0, panel.Width - 1, panel.Height - 1);
                }

            };
        }

        private void ApplyDashedBorder(Panel panel2)
        {
            panel2.BorderStyle = BorderStyle.None;

            panel2.Paint += (sender, e) => {

                Color borderColor = Color.Black;
                int borderThickness = 5;

                using (Pen borderPen = new Pen(borderColor, borderThickness))
                {
                    borderPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;  

                    e.Graphics.DrawRectangle(borderPen, 0, 0, panel2.Width - 1, panel2.Height - 1);
                }

            };
        }
    }
}
