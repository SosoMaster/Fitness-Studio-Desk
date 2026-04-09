using FitnessStudioApp.MODELS.Enumsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.MODELS;


public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; }

    public Client Client { get; set; }
    public Admin Admin { get; set; }
    public Trainer Trainer { get; set; }
}
