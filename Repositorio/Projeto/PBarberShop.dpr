program PBarberShop;

uses
  System.StartUpCopy,
  FMX.Forms,
  ULogin in 'View\ULogin.pas' {FrmLogin};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TFrmLogin, FrmLogin);
  Application.Run;
end.
