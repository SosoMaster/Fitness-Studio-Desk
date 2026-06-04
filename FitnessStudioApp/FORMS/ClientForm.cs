using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.SERVICES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessStudioApp.FORMS;

public partial class ClientForm : Form
{
    private readonly ClientService _clientService;
    private readonly UserService _userService;
    private readonly ILoggerService _logger;
    private int _userId;
    private Client _client;

    public ClientForm(int userId, ClientService clientService, UserService userService)
    {
        InitializeComponent();
        _userId = userId;
        _clientService = clientService;
        _userService = userService;
        _logger = new LoggerService(typeof(ClientForm));
    }

    private async void ClientForm_Load(object sender, EventArgs e)
    {
        try
        {
            _logger.Debug($"Зареждане на ClientForm за UserId={_userId}");

            _client = await _clientService.GetClientByUserId(_userId);
            var user = await _userService.GetByIdAsync(_userId);

            textBox1.Text = user.Username;
            txtb_Email.Text = user.Email;
            txtb_Phone.Text = user.Phone;
            txtb_Password_form.Text = user.Password;
            txtb_Password_form.UseSystemPasswordChar = true;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на ClientForm за UserId={_userId}", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        txtb_Password_form.UseSystemPasswordChar = !chb_ShowPassword_clientform.Checked;
    }

    private async void btn_EditProfile_Click(object sender, EventArgs e)
    {
        try
        {
            _logger.Info($"Обновяване на профил за UserId={_userId}");

            var user = await _userService.GetByIdAsync(_userId);

            user.Username = textBox1.Text;
            user.Email = txtb_Email.Text;
            user.Phone = txtb_Phone.Text;
            user.Password = txtb_Password_form.Text;

            await _userService.Update(user);

            _logger.Info($"Профилът за UserId={_userId} е обновен успешно");
            MessageBox.Show("Профилът е обновен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при обновяване на профил за UserId={_userId}", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}