using System.Net;
using System.Net.Mail;

public class EmailService
{
    private readonly string _mailBody = @"
<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""https://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html
  xmlns=""https://www.w3.org/1999/xhtml""
  xmlns:v=""urn:schemas-microsoft-com:vml""
  xmlns:o=""urn:schemas-microsoft-com:office:office""
>
  <head>
    <meta charset=""UTF-8"" />
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
    <!--[if !mso]><!-- -->
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <!--<![endif]-->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <meta name=""format-detection"" content=""telephone=no"" />
    <meta name=""format-detection"" content=""date=no"" />
    <meta name=""format-detection"" content=""address=no"" />
    <meta name=""format-detection"" content=""email=no"" />
    <meta name=""x-apple-disable-message-reformatting"" />
    <title>Untitled</title>
    <link
      href=""https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap""
      rel=""stylesheet""
    />
    
    <style>
      * {
        font-family: ""Poppins"", sans-serif;
        padding: 0;
        margin: 0;
        font-size: 14px;
      }
      @media all {
        /* cyrillic-ext */
        @font-face {
          font-family: ""Fira Sans"";
          font-style: normal;
          font-weight: 300;
          font-display: swap;
          src: local(""Fira Sans Light""), local(""FiraSans-Light""),
            url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnPKreSxf6Xl7Gl3LX.woff2)
              format(""woff2"");
          unicode-range: U+0460-052F, U+1C80-1C88, U+20B4, U+2DE0-2DFF,
            U+A640-A69F, U+FE2E-FE2F;
        }
        /* cyrillic */
        @font-face {
          font-family: ""Fira Sans"";
          font-style: normal;
          font-weight: 300;
          font-display: swap;
          src: local(""Fira Sans Light""), local(""FiraSans-Light""),
            url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnPKreQhf6Xl7Gl3LX.woff2)
              format(""woff2"");
          unicode-range: U+0400-045F, U+0490-0491, U+04B0-04B1, U+2116;
        }
        /* latin-ext */
        @font-face {
          font-family: ""Fira Sans"";
          font-style: normal;
          font-weight: 300;
          font-display: swap;
          src: local(""Fira Sans Light""), local(""FiraSans-Light""),
            url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnPKreSBf6Xl7Gl3LX.woff2)
              format(""woff2"");
          unicode-range: U+0100-024F, U+0259, U+1E00-1EFF, U+2020, U+20A0-20AB,
            U+20AD-20CF, U+2113, U+2C60-2C7F, U+A720-A7FF;
        }
        /* latin */
        @font-face {
          font-family: ""Fira Sans"";
          font-style: normal;
          font-weight: 300;
          font-display: swap;
          src: local(""Fira Sans Light""), local(""FiraSans-Light""),
            url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnPKreRhf6Xl7Glw.woff2)
              format(""woff2"");
          unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6,
            U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193,
            U+2212, U+2215, U+FEFF, U+FFFD;
        }
        /* cyrillic-ext */
        @font-face {
          font-family: ""Fira Sans"";
          font-style: normal;
          font-weight: 500;
          src: local(""Fira Sans Medium""), local(""FiraSans-Medium""),
            url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveSxf6Xl7Gl3LX.woff2)
              format(""woff2"");
          unicode-range: U+0460-052F, U+1C80-1C88, U+20B4, U+2DE0-2DFF,
            U+A640-A69F, U+FE2E-FE2F;
        }
        /* cyrillic */
        @font-face {
          font-family: ""Fira Sans"";
          font-style: normal;
          font-weight: 500;
          src: local(""Fira Sans Medium""), local(""FiraSans-Medium""),
            url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveQhf6Xl7Gl3LX.woff2)
              format(""woff2"");
          unicode-range: U+0400-045F, U+0490-0491, U+04B0-04B1, U+2116;
        }
        /* latin-ext */
        @font-face {
          font-family: ""Fira Sans"";
          font-style: normal;
          font-weight: 500;
          src: local(""Fira Sans Medium""), local(""FiraSans-Medium""),
            url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveSBf6Xl7Gl3LX.woff2)
              format(""woff2"");
          unicode-range: U+0100-024F, U+0259, U+1E00-1EFF, U+2020, U+20A0-20AB,
            U+20AD-20CF, U+2113, U+2C60-2C7F, U+A720-A7FF;
        }
        /* latin */
        @font-face {
          font-family: ""Fira Sans"";
          font-style: normal;
          font-weight: 500;
          src: local(""Fira Sans Medium""), local(""FiraSans-Medium""),
            url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveRhf6Xl7Glw.woff2)
              format(""woff2"");
          unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6,
            U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193,
            U+2212, U+2215, U+FEFF, U+FFFD;
        }
        /* cyrillic-ext */
        @font-face {
          font-family: ""Fira Sans"";
          font-style: normal;
          font-weight: 800;
          font-display: swap;
          src: local(""Fira Sans ExtraBold""), local(""FiraSans-ExtraBold""),
            url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eSxf6Xl7Gl3LX.woff2)
              format(""woff2"");
          unicode-range: U+0460-052F, U+1C80-1C88, U+20B4, U+2DE0-2DFF,
            U+A640-A69F, U+FE2E-FE2F;
        }
        /* cyrillic */
        @font-face {
          font-family: ""Fira Sans"";
          font-style: normal;
          font-weight: 800;
          font-display: swap;
          src: local(""Fira Sans ExtraBold""), local(""FiraSans-ExtraBold""),
            url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eQhf6Xl7Gl3LX.woff2)
              format(""woff2"");
          unicode-range: U+0400-045F, U+0490-0491, U+04B0-04B1, U+2116;
        }
        /* latin-ext */
        @font-face {
          font-family: ""Fira Sans"";
          font-style: normal;
          font-weight: 800;
          font-display: swap;
          src: local(""Fira Sans ExtraBold""), local(""FiraSans-ExtraBold""),
            url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eSBf6Xl7Gl3LX.woff2)
              format(""woff2"");
          unicode-range: U+0100-024F, U+0259, U+1E00-1EFF, U+2020, U+20A0-20AB,
            U+20AD-20CF, U+2113, U+2C60-2C7F, U+A720-A7FF;
        }
        /* latin */
        @font-face {
          font-family: ""Fira Sans"";
          font-style: normal;
          font-weight: 800;
          font-display: swap;
          src: local(""Fira Sans ExtraBold""), local(""FiraSans-ExtraBold""),
            url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eRhf6Xl7Glw.woff2)
              format(""woff2"");
          unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6,
            U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193,
            U+2212, U+2215, U+FEFF, U+FFFD;
        }
      }
    </style>
    
  </head>

  <body class="""" style="""" bgcolor=""#f4f4f4"">
    <table
      style=""table-layout: fixed; min-width: 600px""
      bgcolor=""#11111""
      width=""100%""
      height=""850px""
      border=""0""
      cellspacing=""0""
      cellpadding=""0""
      role=""presentation""
    >
      <tr>
        <td align=""center"" valign=""top"">
          <table
            class=""pc-project-container""
            style=""width: 600px; max-width: 600px""
            width=""600""
            align=""center""
            border=""0""
            cellpadding=""0""
            cellspacing=""0""
            role=""presentation""
          >
            <tr>
              <td style=""padding: 20px 0px 20px 0px"" align=""left"" valign=""top"">
                <table
                  border=""0""
                  cellpadding=""0""
                  cellspacing=""0""
                  role=""presentation""
                  width=""100%""
                  style=""width: 100%""
                >
                  <tr>
                    <td valign=""top"">
                      <!-- BEGIN MODULE: Header 2 -->
                      <table
                        width=""100%""
                        border=""0""
                        cellspacing=""0""
                        cellpadding=""0""
                        role=""presentation""
                      >
                        <tr>
                          <td style=""padding: 0px 0px 0px 0px"">
                            <table
                              width=""100%""
                              border=""0""
                              cellspacing=""0""
                              cellpadding=""0""
                              role=""presentation""
                            >
                              <tr>
                                <td
                                  valign=""top""
                                  class=""pc-w520-padding-30-30-30-30 pc-w620-padding-35-35-35-35""
                                  style=""
                                    padding: 40px 40px 40px 40px;
                                    border-radius: 0px;
                                    background-color: #1b1b1b;
                                    background-position: -20px -20px;
                                  ""
                                  background=""https://i.ibb.co/G94ftcQ/Letter-1.png""
                                >
                                  <table
                                    width=""100%""
                                    border=""0""
                                    cellpadding=""0""
                                    cellspacing=""0""
                                    role=""presentation""
                                    align=""center""
                                    style=""
                                      margin-top: 180px;
                                      margin-bottom: 40px;
                                      color: white;
                                    ""
                                  >
                                    <tr>
                                      <td style=""width: 100px""></td>
                                      <td
                                        align=""center""
                                        style=""
                                          font-weight: 500;
                                          background-color: #261b66;

                                          padding: 5px 0 5px;
                                          border-radius: 5px;
                                          transform: rotate(-3deg);
                                          font-size: 18px;
                                        ""
                                      >
                                        Store Publish Status
                                      </td>
                                      <td style=""width: 100px""></td>
                                    </tr>
                                  </table>

                                  <table
                                    width=""100%""
                                    border=""0""
                                    cellpadding=""0""
                                    cellspacing=""0""
                                  >
                                    <tr>
                                      <td valign=""top"" align=""center"">
                                        <div
                                          class=""""
                                          style=""
                                            letter-spacing: -0.2px;
                                            font-size: 14px;
                                            padding: 0 50px 0;
                                            text-align: justify;
                                            color: #1b1b1b !important;
                                          ""
                                        >
                                          <p>Dear [STORE OWNER],</p>
                                          <br />
                                          <p class=""section"">
                                            The changes made to your store
                                            coupon has been <b>approved</b>,
                                            your coupon will be publsihed
                                            shortly.
                                          </p>
                                          <br />
                                          <p>
                                            <b
                                              >Here are remarks shared by your
                                              Key Account Manager.</b
                                            >
                                          </p>
                                          <br />
                                          <p>XXX</p>
                                          <br />
                                          <p>
                                            If you have any questions or
                                            concerns? Please reach out to your
                                            Key Account Manager and allow 1-2
                                            Business Days for response.
                                          </p>
                                          <br />
                                          <p>Treat Team</p>
                                          <p class=""email text"">
                                            support@treatinc.ca
                                          </p>
                                        </div>
                                      </td>
                                    </tr>
                                  </table>

                                  <table
                                    width=""100%""
                                    border=""0""
                                    cellpadding=""0""
                                    cellspacing=""0""
                                    role=""presentation""
                                  >
                                    <tr>
                                      <td
                                        align=""center""
                                        valign=""top""
                                        style=""padding: 0px 0px 29px 0px""
                                      >
                                        <table
                                          border=""0""
                                          cellpadding=""0""
                                          cellspacing=""0""
                                          role=""presentation""
                                          width=""100%""
                                          style=""
                                            border-collapse: separate;
                                            border-spacing: 0;
                                            margin-right: auto;
                                            margin-left: auto;
                                          ""
                                        >
                                          <tr>
                                            <td valign=""top"" align=""center"">
                                              <div
                                                class=""pc-font-alt pc-w620-fontSize-16 pc-w620-lineHeight-26""
                                                style=""
                                                  line-height: 156%;
                                                  letter-spacing: -0.2px;
                                                  font-family: 'Fira Sans',
                                                    Arial, Helvetica, sans-serif;
                                                  font-size: 14px;

                                                  font-variant-ligatures: normal;

                                                  text-align: center;
                                                  text-align-last: center;
                                                  padding-bottom: 160px;
                                                ""
                                              ></div>
                                            </td>
                                          </tr>
                                        </table>
                                      </td>
                                    </tr>
                                  </table>
                                  <table
                                    width=""100%""
                                    border=""0""
                                    cellpadding=""0""
                                    cellspacing=""0""
                                    role=""presentation""
                                  >
                                    <tr>
                                      <td align=""center"">
                                        <table
                                          class=""pc-width-hug pc-w620-gridCollapsed-0""
                                          align=""center""
                                          border=""0""
                                          cellpadding=""0""
                                          cellspacing=""0""
                                          role=""presentation""
                                        >
                                          <tr
                                            class=""pc-grid-tr-first pc-grid-tr-last""
                                          >
                                            <td
                                              class=""pc-grid-td-first pc-grid-td-last""
                                              valign=""top""
                                              style=""
                                                padding-top: 0px;
                                                padding-right: 0px;
                                                padding-bottom: 0px;
                                                padding-left: 0px;
                                              ""
                                            >
                                              <table
                                                border=""0""
                                                cellpadding=""0""
                                                cellspacing=""0""
                                                role=""presentation""
                                                style=""
                                                  border-collapse: separate;
                                                  border-spacing: 0;
                                                ""
                                              >
                                                <tr>
                                                  <td
                                                    align=""center""
                                                    valign=""top""
                                                  >
                                                    <table
                                                      align=""center""
                                                      border=""0""
                                                      cellpadding=""0""
                                                      cellspacing=""0""
                                                      role=""presentation""
                                                    >
                                                      <tr>
                                                        <td
                                                          align=""center""
                                                          valign=""top""
                                                        >
                                                          <table
                                                            width=""100%""
                                                            border=""0""
                                                            cellpadding=""0""
                                                            cellspacing=""0""
                                                            role=""presentation""
                                                          >
                                                            <tr>
                                                              <th
                                                                valign=""top""
                                                                align=""center""
                                                                style=""
                                                                  padding: 0px
                                                                    0px 0px 0px;
                                                                  text-align: center;
                                                                  font-weight: normal;
                                                                  line-height: 1;
                                                                ""
                                                              >
                                                                
                                                              </th>
                                                            </tr>
                                                          </table>
                                                        </td>
                                                      </tr>
                                                    </table>
                                                  </td>
                                                </tr>
                                              </table>
                                            </td>
                                          </tr>
                                        </table>
                                      </td>
                                    </tr>
                                  </table>
                                </td>
                              </tr>
                            </table>
                          </td>
                        </tr>
                      </table>
                      <!-- END MODULE: Header 2 -->
                    </td>
                  </tr>
                  <tr>
                    <td>
                      <table
                        width=""100%""
                        border=""0""
                        cellpadding=""0""
                        cellspacing=""0""
                        role=""presentation""
                      >
                        <tr>
                          <td
                            align=""center""
                            valign=""top""
                            style=""
                              padding-top: 20px;
                              padding-bottom: 20px;
                              vertical-align: top;
                            ""
                          >
                            <a
                              href=""https://designmodo.com/postcards?uid=MjUxMDE0&type=footer""
                              target=""_blank""
                              style=""
                                text-decoration: none;
                                overflow: hidden;
                                border-radius: 2px;
                                display: inline-block;
                              ""
                            >
                            </a>
                            <img
                              src=""https://api-postcards.designmodo.com/tracking/mail/promo?uid=MjUxMDE0""
                              width=""1""
                              height=""1""
                              alt=""""
                              style=""display: none; width: 1px; height: 1px""
                            />
                          </td>
                        </tr>
                      </table>
                    </td>
                  </tr>
                </table>
              </td>
            </tr>
          </table>
        </td>
      </tr>
    </table>
    <!-- Fix for Gmail on iOS -->
    <div
      class=""pc-gmail-fix""
      style=""white-space: nowrap; font: 15px courier; line-height: 0""
    >
      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    </div>
  </body>
</html>
";
    private readonly string _subject = "Welcome to Nehanth World.";
    private readonly string _mailTitle = "Email from .Net Core App";
    private readonly string _fromEmail = "dummyBro123@outlook.com";
    private readonly string _fromEmailPassword = "dummybro@outllook";
    
    public bool SendEmail(string toEmail)
    {
        try
        {
            MailMessage message = new MailMessage(new MailAddress(_fromEmail, _mailTitle), new MailAddress(toEmail));
            message.Subject = _subject;
            message.Body = _mailBody;
            message.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.office365.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_fromEmail, _fromEmailPassword)
            };

            smtp.Send(message);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
