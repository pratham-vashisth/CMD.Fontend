   M S B A M L   `   `   `  ????F  BCMDFrontend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CMDFrontend.Appointment.ViewCMDFrontend.Appointment.View  5      :    4CMDFrontend.Appointment.View.AppointmentConfirmation   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:CMDFrontend.Appointment.View     5      _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $	??500??5	      $	??500??6   $	??800??5
      $	??800??6     ? Title$  AppointmentConfirmation??5      .??5      ? 
???????$??-1,0,1,0q?6   .+?5   
   ?? -   5         ??Name$ AppointmentConfirmation1??5      $??0??64   
???????$??10q?5       ? 	Resources 5       ?? 
TargetType ?? Property ?? Value??%_   '??       ?? 5      " ??6   .?5      ??  ?@??CornerRadius$ 15??65   5      5      ??5      ?? 5      .R?5      ? $	??750??6   $??Center=?6'   $??Center=?6D    ? RowDefinitions 5      ?? 5      ?? 5      ?? 5      .+?5      ?? $??0??6%   .+?5       ?? $??Appointment Confirmation??6$   $??Center=?6G   $??24(?6d   $??Italic$?5!   $   $
??Bold"?5"   $   ???#06283D66   ?? 5#      5$      ? 5%      $??1??6    ? ColumnDefinitions 5&      ?? 5'   "   ?? 5(   "   $??70 ?63   ?? 5)   "   .+?5+      ? $??0??6#    5,   "   ?? 5-   &   ?? 5.   &   .+?50   "   ?? $??0??6-   .+?51   &   ?? $??Patient??6,   $??Italic$?6>   
???????$??18(?6c   $??Center=?6q   ?? 52   &    ?? Orientation$ 
Horizontal=?61   $??Center=?6J   .+?53   *   A? $??0??62   $??60??6B   $??60??6M   $	??Top=?54   *   $
??Left=?55   *   ??56   .   ?? 57   2   	 ?? ImageSource	 6=   ?? *
PatImage+59   +   ? 5:   *   $??60??6/    5;   .   ?? 5<   2   ?? 5=   2   .+?5?   .   ?? $??0??6U   $??Italic$?6b   $
??Bold"?6u   ??64   ?? *PatientName+6u   5A   +   5B   '   5C   #   ? 5D   "   $	??250??6'   $??1??63    5E   &   ?? 5F   *   $
??143* ?6;   ?? 5G   *   $
??107* ?6;    5I   &   ?? 5J   *   $??1 ?6:   ?? 5K   *   $??10 ?68   ?? 5L   *   $??36 ?68   ?? 5M   *   $??10 ?68   ?? 5N   *   $??36 ?68   ?? 5O   *   $??10 ?68   ?? 5P   *   $??32 ?68   .+?5S   &   ?? $??1??61   $??Italic$?6>   $??8(?6Q   ???#23aadb
???????$??26??6?   $
??Left=?6?   $??	112,0,0,0q?6?   Time6?   ?? 5T   &   $??2??6G   $??28??6T   $??Italic$?6`   ???#23aadb$??1q?6?   $??2??6?   $??0,4,0,4q?6?   ??6,   ?? *Issue+6?   ?? 5V   &   $??3??60   $??8(?6>   $??Italic$?6K   ???#23aadb
???????$??26??6?   $
??Left=?6?   $??	112,0,0,0q?6?   Reason6?   ?? 5W   &   $??4??6O   $??28??6]   $??Italic$?6i   ???#23aadb$??1q?6?   $??2??6?   $??0,4,0,4q?6?   ??6,   ?? *ReasonForVisit+6?   ?? 5X   &   $??5??60   $??8(?6>   $??Italic$?6K   ???#23aadb
???????$??42??6?   $
??Left=?6?   $??2??6?   $??	104,0,0,0q?6?   Priscription6?   ?? 5Y   &   $??6??6-   $??28??6;   $??Italic$?6G   ???#23aadb$??1q?6p   $??2??6?   $??0,2,0,2q?6?   6?   5Z   #   5[      ? 5\      $??1??6#   .+?5]   "   ?? $'??!\Image\AppointmentConfirmLogo.png??6(   $	??Top=?5^   (   5_      ? 5`      $??2??6#    5a   "   ?? 5b   &   ?? 5c   &   .+?5e   "   ?? $??0??6-   .+?5f   &   ?? $	??PCP??6,   $??Italic$?6:   
???????$??18(?6_   $??Center=?6m   ?? 5g   &   $ 
Horizontal=?61   $??Center=?6J   .+?5h   *   A? $??0??62   $??60??6B   $??60??6M   $	??Top=?5i   *   $
??Left=?5j   *   ??5k   .   ?? 5l   2   	 6=   ?? *
DocImage+5n   +   ? 5o   *   $??60??6/    5p   .   ?? 5q   2   ?? 5r   2   .+?5t   .   ?? $??0??6S   $??Italic$?6`   $
??Bold"?6s   ??64   ?? *
DoctorName+6?   5v   +   5w   '   5x   #   ? 5y   "   $??1??6'   $	??250??64    5z   &   ?? 5{   *   $??1 ?68   6E   ?? 5|   *   $??10 ?68   6F   ?? 5}   *   $??36 ?68   6F   ?? 5~   *   $??10 ?68   6F   ?? 5   *   $??36 ?68   6F   ?? 5?   *   $??10 ?68   6F   ?? 5?   *   $??32 ?68   6F   .+?5?   &   ?? $??1??60   $??8(?6>   $??Italic$?6K   ???#23aadb
???????$??26??6?   $??Center=?6?   
Speciality6?   ?? 5?   &   $??2??6K   $??28??6X   $??Italic$?6d   ???#23aadb$??1q?6?   ??6,   ?? *
Speciality+6?   ?? 5?   &   $??3??60   $??8(?6>   $??Italic$?6K   ???#23aadb
???????$??26??6?   $??Center=?6?   
TimeSlot6?   ?? 5?   &   $??4??6J   $??28??6W   ???#23aadb$??Italic$?6y   $??1q?6?   ??6,   ?? *
TimeSlot+6?   ?? 5?   &   $??5??60   $??8(?6>   $??Italic$?6K   ???#23aadb
???????$??26??6?   $??Center=?6?   status6?   ?? 5?   &   $??6??6T   $??28??6a   ???#23aadb$??Italic$?6?   $??1q?6?   ??6,   ?? *Appointment_status+6?   5?   #   5?      5?      ?? 5?      
 ??Name$
 BackHomePage??6!   -   5        $??2??5?   !   $
??Exit??5?   !   $??Center=?5?   !   $??Italic$?5?   !   ???#06283D5?   !   ?? 5?      $??mynameis??6"   5?      5?      .@?5?      )  #MaterialDesignThemes.Wpf.TimePicker  5?      5?      5?      