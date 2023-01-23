﻿using Google.Protobuf.WellKnownTypes;
using System.Net.NetworkInformation;
using System.Xml.Linq;
@model Piece

<h2>Create a New Piece</h2>

@using (Html.BeginForm("InsertPieceToDatabase", "Piece", "Post"))
{
    < input asp -for= "PieceID" type = "hidden" value = "" />

    < label asp -for= "Name" class= "control-label" > Name </ label >
    < input type = "text" name = "Name" class= "form-control" value = "" />

    < label asp -for= "Price" class= "control-label" > Price </ label >
    < input type = "number" step = "0.01" name = "Price" class= "form-control" />

    < div class= "form-group" >
        < label for= "" > Select a Category </ label >
        < select class= "form-control" name = "CategoryID" value = "" >
            @foreach(var cat in Model.Categories)
            {
                < option value = "@cat.CategoryID" > @cat.CategoryID @cat.Name </ option >
            }
        </ select >
    </ div >


    < input type = "submit" value = "Create Product" class= "btn btn-primary" />
}