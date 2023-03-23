<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProviderView.aspx.cs" Inherits="WebApplication1.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Provider View</title>
</head>
<body>
   <h1 id="welcomeHeader" runat="server"> </h1>
    <br />
    <br />
<!--
    Where appointment view was
-->
<!-- Fill out to add new doctor, nurse, staff-->
  <div class="header">
    <div class="container">
      <a class="btn" href="New_____.aspx">Add New Personnel</a>
    </div>
    <div class="container">
      <a class="btn" href="New_____.aspx">Add New Office</a>
    </div>
    <div class="container">
      <a class="btn" href="Remove_____.aspx">Remove Personnel</a>
    </div>
    <div class="container">
      <a class="btn" href="New_____.aspx">Remove Office</a>
    </div>
  </div>
                <!--- Beginning of Newsletter Code -->
            <div style="text-align: center; margin-bottom:2cm; margin-top:1px">
             <!-- Button to launch a modal -->
    <button type="button"
        class="btn btn-primary"
        data-toggle="modal"
        data-target="#exampleModal">
        Add New Personnel
    </button>
  
    <!-- Modal -->
    <div class="modal fade"
        id="exampleModal"
        tabindex="-1"
        role="dialog"
        aria-labelledby="exampleModalLabel"
        aria-hidden="true">
         
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-body">
                    <h1>Add new Personnel</h1>
                    <p>Please fill out where indicated</p>
                    <div class="form-group">
                      <label for="officelabel">
                          <br />
                              Select a personnel type <span class="required">*</span></label>&nbsp;
                              <asp:DropDownList ID="DropDownList1" runat="server" Width="140px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                              </asp:DropDownList>
                           <br />
                       <br />
                    </div>
                    <div class="form-container">
                      <form id="form2" runat="server">
                      <fieldset>
                      <legend>Contact Information</legend>
                        <div class="form-group">
                          <label for="first-name">
                                  <br />
                                  First Name <span class="required">*</span></label>&nbsp;
                                  <asp:TextBox ID="fname" runat="server" ></asp:TextBox>
                        </div>

                        <div class="form-group">
                          <label for="middle-initial">Middle Initial</label>&nbsp;
                                  <asp:TextBox ID="mi" runat="server"></asp:TextBox>
                        </div>

                        <div class="form-group">
                          <label for="last-name">Last Name <span class="required">*</span></label>&nbsp;
                                  <asp:TextBox ID="lname" runat="server"></asp:TextBox>
                          </div>

                        <div class="form-group">
                          <label for="date-of-birth">Date of Birth <span class="required">*</span></label>&nbsp;
                                  <asp:TextBox ID="dob" runat="server" TextMode="Date" DataFormatString="{yyyy/MM/dd}"></asp:TextBox>
                        </div>

                              <div class="form-group">
                                  <label for="phone">Phone Number <span class="required">*</span></label>&nbsp;
                                  <asp:TextBox ID="phone_num" runat="server" placeholder="1234567890" MaxLength="10" />
                                  <asp:RegularExpressionValidator ID="phoneValidator" runat="server" ControlToValidate="phone_num"
                                      ValidationExpression="^\d{10}$" ErrorMessage="Please enter a valid phone number" />
                              </div>



                        <div class="form-group">
                          <label for="email">Email <span class="required">*</span></label>&nbsp;
                                  <asp:TextBox ID="email" runat="server" placeholder="you@example.com"></asp:TextBox>
                                  <asp:RegularExpressionValidator ID="emailValidator" runat="server" 
                                  ControlToValidate="email" ErrorMessage="Please enter a valid email address." 
                                      ValidationExpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$" />
                        </div>
                        </div>
                         <script>
                        //Client-side jQuery to cancel form submission if required fields empty 
                            $(function () {
                                // Attach event handler to form submit button click
                                $('#<%=SUBMIT.ClientID %>').on('click', function () {
                                    // Check if required fields are filled out
                                    if ($('#<%=fname.ClientID %>').val() === '' || $('#<%=lname.ClientID %>').val() === '' || $('#<%=email.ClientID %>').val() === ''
                                        || $('#<%=phone_num.ClientID %>').val() === '' || $('#<%=address.ClientID %>').val() === ''){
                                        // Display dialog box
                                        alert('Please fill out all required fields.');
                                        return false; // Cancel form submission
                                    }
                                });
                            });
                        </script>
                        <!-- END MODAL: NEW PERSONNEL--->
                        <div class="modal-footer">
                            <button type="button"
                                class="btn btn-secondary"
                                data-dismiss="modal">
                                Close
                        </button>
                        </div>
                    </div>
                </div>
    </div>
   
    <!-- Adding scripts to use bootstrap -->
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"
            integrity=
"sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"
            crossorigin="anonymous">
    </script>
    <script src=
"https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"
            integrity=
"sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"
            crossorigin="anonymous">
    </script>
    <script src=
"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"
            integrity=
"sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"
            crossorigin="anonymous">
    </script>
            </div>
            <!--- End of Newsletter Code-->
  </div>
</body>
</html>
