﻿namespace petaverse.frontend.mauiapp;

public record RegisterDTO(string username,
                          string firstname,
                          string lastname,
                          string phonenumber,
                          string email,
                          string password,
                          string profilepic)
{ }
