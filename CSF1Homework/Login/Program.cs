using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Instructions for Login Page

            /*
             * Ask for Username
             * 
             * If it matches your one hard-coded, correct username, tell the user to they have access.  If not, tell the user that they have been denied access.
             * 
             * Make sure the usernames (hard-coded & user input are case insensitive (uppercase or lowercase).
             * 
             * ADDITIONAL FUNCTIONALITY
             * 
             * Encase the username functionality in a loop that allows the user to make another attempt if the previous attempt was unsuccessful.
             * 
             * Extend the loop functionality to deny access to the user if they enter the wrong username 3 times. 
             * 
             * Extend the username functionality to ask for a password if the user entered the correct username.  Deny access if the password is entered incorrectly 3 times.  (Note: 3 attempts at username if the correct username is entered, give 3 attemps for the correct password.)
             */

            #endregion

            #region Variables

            const string userName = "CMITCHELL";
            const string userPassword = "WebDeveloper";
            string firstNameUser = "Caleb";
            string inputUserName;
            string inputPassword;
            int attemptsRemaining;
            bool loopExit = true;

            #endregion

            Console.Title = "====== Web Developer Login Station ======";

            Console.WriteLine("\nWelcome to the Web Developers Login. \n\nPlease Login to continue:"); //Welcome Screen

            Console.WriteLine("\n\nPlease enter your username.");  //Prompt user for their username.
            

            for (int userAttempts = 1; userAttempts <= 3; userAttempts++)
            {
                Console.Write("\nusername:  ");
                inputUserName = Console.ReadLine().ToUpper();

                switch (inputUserName)
                {
                    case userName:
                        goto userCorrect;
                        break;
                    default:
                        Console.WriteLine($"\n\nAccess denied.  Username {inputUserName} not found. \n\nPlease re-enter your username. \n\nYou have {attemptsRemaining = 3 - userAttempts} attempts remaining. ");
                        break;
                } //END SWITCH USERNAME
            } // END FOR LOOP USERNAME

            return;

        userCorrect:;

            Console.WriteLine($"\n\nHi {firstNameUser}, Please enter your password to gain access.");

            for (int userAttempts = 1; userAttempts <= 3; userAttempts++)
            {
                Console.Write("\n\npassword:  ");
                inputPassword = Console.ReadLine();

                switch (inputPassword)
                {
                    case userPassword:
                        goto passwordCorrect;
                        break;
                    default:
                        Console.WriteLine($"\n\nAccess denied.  Incorrect password. \n\nPlease re-enter your password. \n\nYou have {attemptsRemaining = 3 - userAttempts} attempts remaining. ");
                        break;
                } //END SWITCH PASSWORD

            } // END FOR LOOP PASSWORD

            return;

        passwordCorrect:;
            Console.Clear();
            Console.WriteLine("\n\n\n\nYou've successfully logged in through the Web Developers login page!!!");
            Console.WriteLine("Here is a picture of Dwight Schrute as a congratulations!!!");
            Console.WriteLine("\n\n" + @"                           `/+o/.
                       .+sso+/:oydyo/:-:+shdys/    `-:.     `-/+o+/`
                 `/sdh+/::/::ss:`ymdhyso//hmMNyhNNms+ososys+/-:/shms/`
                .+hNNy++oo+/.`.--/osyhdmNNMMMMMMMMMNdsssssoso+hhhhsoo+ymdo.
              -smNy/+ymmmmmNNNNMNMMMMMNNNmmNMMMMMMMMMho:///:--shydNMMNdo-sNs`
            -hNd+-sNMNdmNMMMNNNMNNNMMMddNMMNNmNMMMMMMNmy+///::/:-:/++ymNNdmMN:
          `sNMs`+NMNNNMMMMNNNMMMMMMNmhyso///+ohMmoNMmoo+/::/-:oymNNmsosshdhmMM/
         +NMMy`hMMMhyNMNMMNNNMds:-.`-:syddmNMMmyo`+yMMho:..-+//++omMNNNNNNNmdNMs
       :mMMMh`yMNdodNNNMNMMMs.+sdmmmmmdhNMMMNhy/..`-syhNmdyssso+/.`:yNMMMMNMNMMMy
      :NMNh:-+MMh+mdNNNNNMd.+NNMMMMMMMMmho:-......:--::ohNMMMMMMNmNy/.oNMNmNMNMMMs
     :NMm+/dmmMNydyhNdhMMN.yMMNmhysso+:-``        ```.--:/+sdMMMMMNNNm:-mMNNNNMMMMy
    :NMy/hNMMMMmNddsh/NmMy-Mms:..`.--.`                ``..-.:yNMMMMNMNs:NMMMNNNNMMy
   :NNy/mMMMMMMmNMMshsNdMo/d-...``                       ```...-yMMMNNMd`NMMNMdmoNMM-
  /mMm+NMNNMMNMNNNNNNNNMMmom/                              ```..`+NMMMMh`NMMMMNNdhNMh
 +NMMmmMNyNMNMMMMMNmmmNMdNNyh+.                             ``````/NMMM::MMMMNMNNmNMN
+MNNMMMNymMNNMMMNNNNNMh+:+dNmddhyoo+`                        ````.`sMMN`sMNNMNNMNNNNN
dNNNMNNddMNNNNNNmymMN+---::/shdhyyy:                         `````..hMo.NMNMNMMMNmMMd
dNNNMMNmNNNmmNMNdNMM+.-..----.-:::.                          ````...:mh/NMMMNMMMNNMMh
sMNNMMNMNNmyNMNdmNMo--.....                                  ``...---:dNMNMMNMMNNNMMN.
:NNNMMMNNNsmMNmMNMy...`.-.`                                    `.-----:odNmmNMMMMMNMMo
.NMMMmMMMNmMNNNNMm:-.```..                                       ``-----:/o//dMMMNMMMm
.NMMMNMMNMMNMNNNNs--.``...                                         `....---..dMNMMMMM`
.NNMMNNNNNMMMNNNN:-...`...                                          ```.....`+MMMMMMM.
.MNNNNNNNMMMMMNNy.......-.`                                         ``..---.`.NMMMMMM`
`NMNMMNNNMMNMMMm-...`.-----.`                                        ``.-----.`yMMMMMd
 dMMMNNNNMMNNMMo`-....----..`          ``                      `.`` ```.------`:MMMMM-
 /MMNMNNNMMNMMN-`.`..-.--.` `--..-:-.-.``..``               ```.-......--.----..NMMMd
 `mMNMNNMMMNNMN.``...-.-../hddyysyhysyyso+--/::-..--...----:::+syyyyhhdddy+:-.-.hMMM:
  :NNNNNNMMMMMN.`....--.:dy/:-.-/+++ososss+/:+shyo/::/:+os+:+syosyoso+/://ss//.`+MMm
   +MdmNNMNMMMN+.--....:+-.-:+ooymdddmdhyo++ss+/yMo.`..oNsyhdhmdmmmmNmdo:-.--:+-:MM/
  `y/..-+dNNMMMo-shhyo++--+sso-`dsymoso.smyso+//.od+/:/ho+yyhd/ymsNhyy./yy/``.-hhmm`
  .s+md+- oMMMm``.-/sy//-.+/s.  odys+s-  /shyso+.sm+:::yd/hh+:`.hyyhy- `/y/.` `hs/s`
  -oyMNyhs:NMMo     `.-`         .---` ``.`/::+s/ms````-mo+:`````.--` ````     `sNm`
  `hsMh`.hymMM:       `-         `          .:+:hy`     od:-`                  .+sM-``
   o+o/``-/mMM-        .-                ``.```hy`       s.`.`                 -/+M+``
   .s `./NMMMM-         --            ````  `:ho`        .s`  ```             ./.+My`
    /: `+MMdMM/          -.  `       `   ..+++-           :d/.             ``:o-`oMy
     o. .sdNMMm`            `--:://+//.`-///:.           `.ohooo:-.`` `.-:+//:..`hMy
     `s```.yMMMs                  ```     .y+  `::.:----.-``o:-::/:::--:::-----..mMo
      :s` `oMNMN-                         :N+  -NNhy/:/sds./:..----------------`/MN
        +o``-NMNMd`                      `-syyoo++/.++:so/+yN+..--....-..-....--`dM+
        +:.`oMNNN`                     .:-` `.::.` `--..---/+/---.```........-.:d:
         ./++Ny::`                   `--`          .--..-----::-..```......---.s.
           `:os.--`                  .`            `.. ``.------.`.```..-----.:o
             `h-..`                 ``        .:syy/-/ydho-.--...`````.------.+.
              +o`.`                        ./ymNNNNNNNmmNNNh:....``.```.-----:s
              `h-`.                    -/+oyo/:----:---.--:+sso:........--::-+:
               /d...                 `.++:  -:--/+:/oo+o++-.``--.....-----:-:y
               `Md:.`                ``     `-:/+ooooo+/-........-----------yo
                mNNs-`                     `..-/oo+://:/oo:......----------os
                h:+md:.                  ...``.`         `------.---------++
               `h..-+ddo.`                            ``.----------------s:
                h` .--/ydy:`                   `...--------------------+y.
                h`   ..--+yds+.`               `....----------------:+dN`
               `y      `.-.-:sdhs:.`    `...````..----------------:smsdm
               `h         .--..-+ymdy+/:----:----------------.-/shs+.`os
               `h           `..--..:sdmmhyo/::----------::/+syhy/....`+-
               -y              `..--..--/oosyyyhhhyyyssoooo/:.`...`.` /-
               `.                  `..--.......................````   +`
                                      `...------..-.........``
                                          ``..-.--........``
                                               ```..```

");
            Console.WriteLine();
            Console.ReadKey();

        }// END MAIN

    }// END CLASS

} // END NAMESPACE
