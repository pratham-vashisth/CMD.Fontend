   M S B A M L   `   `   `  ????F  BCMDFrontend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CMDFrontend.Appointment.ViewCMDFrontend.Appointment.View  5      (    "CMDFrontend.Appointment.View.Step2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      6local*clr-namespace:CMDFrontend.Appointment.View  5        ? Title$  Step2??5
      .??5      ? 
??????? ? ColumnDefinitions 5   
   ?? 5      $??3* ?6   ?? 5      .+?5   
   ? $??0??6    ? RowDefinitions 5      ?? 5      $??80 ?6    ?? 5      $	??120 ?6    ?? 5      $	??170 ?6    ?? 5      .+?5      ?? $??0??6   $/??)Choose reason/Type reason for Appointment??6!   $??20(?5      $??Italic$?6"   $??Center=?5      $??0,35,0,0q?5      
???????$??DemiBold"?5      ?? 5      $??1??6   $??\image\step2.png??6!   ? 5      $??2??6    5       ?? 5!      ?? 5"      .+?5$      ?? $??0??6   .+?5%      ?? $??Patient's Issue??6   $??15(?5&      $??Italic$?6&   $
??Bold"?5'      ???#06283D$
??30,0q?5)      ?? 5*      $
??30,0q?6   
???????$??1q?5,      $	??200??5-       ?? CornerRadius$ 10??5.      $
??Left=?5/      ._?50      ?? -   5        $??IssueTextBox??50   "   $??30??66   $	??200??51       $??Italic$?6,   52      ?? 53      $??30,70q?6   
???????$??1q?55      $	??200??56      $ 10??57      $
??Left=?58      ._?59      ?? -   5        $??ReasonTextBox??59   "   $??Italic$?67   $??30??6J   $	??200??5:       $!??  Or Enter Reason for Visit??6,   
???????5;   $   5<      5=      5>      ?? 5?      -   5         ??Name$ AppointmentStep2??5?      $??Confirm??6/   $??3??6A   $	??100??5@      $??35??6)   
???????
??????? ? 	Resources 5C       ?? 
TargetType ?? Property ?? Value??%_   '??       ?? 5D      " ??6   .?5E      ??  ?@??CornerRadius$ 15??69   5F      5G      5H      5J      5K      5L      