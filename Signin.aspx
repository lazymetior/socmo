<%@ Page Title="" Language="VB" MasterPageFile="~/socmo.master" AutoEventWireup="false" CodeFile="Signin.aspx.vb" Inherits="Signin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-4">
                <div class="text-center mb-4">
                    <h2 class="text-success">socmo</h2>
                  
                </div>
                <form>
                    <div class="mb-3">
                        <label for="profile-image" class="form-label">Profile Image (Image files only)</label>
                        <input type="file" class="form-control" id="profile-image" accept="image/*">
                    </div>
                    <div class="mb-3">
                        <label for="username" class="form-label">Username</label>
                        <input type="text" class="form-control" id="username" placeholder="Enter your username">
                    </div>
                    <div class="mb-3">
                        <label for="email" class="form-label">Email address</label>
                        <input type="email" class="form-control" id="email" placeholder="Enter your email">
                    </div>
                    <div class="mb-3">
                        <label for="password" class="form-label">Password</label>
                        <input type="password" class="form-control" id="password" placeholder="Enter your password">
                    </div>
                    <div class="mb-3">
                        <label for="confirm-password" class="form-label">Confirm Password</label>
                        <input type="password" class="form-control" id="confirm-password" placeholder="Confirm your password">
                    </div>
                    <div class="mb-3">
                        <button type="submit" class="btn btn-primary w-100">Sign In</button>
                    </div>
                    <p class="text-center">Already have an account? <a href="Login.aspx">Log in</a></p>
                </form>
            </div>
        </div>
    </div>

</asp:Content>

