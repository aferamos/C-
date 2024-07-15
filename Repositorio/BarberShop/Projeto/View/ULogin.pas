unit ULogin;

interface

uses
  System.SysUtils, System.Types, System.UITypes, System.Classes, System.Variants,
  FMX.Types, FMX.Controls, FMX.Forms, FMX.Graphics, FMX.Dialogs, REST.Types,
  FMX.Edit, FMX.StdCtrls, FMX.Controls.Presentation, FMX.Objects, FMX.Layouts,
  FMX.TabControl, REST.Client, Data.Bind.Components, Data.Bind.ObjectScope,
  System.Actions, FMX.ActnList;

type
  TFrmLogin = class(TForm)
    ActionList1: TActionList;
    ActionTabLogin: TChangeTabAction;
    ActionTabPainel: TChangeTabAction;
    ActionTabConfiguracao: TChangeTabAction;
    ActionTabAgenda: TChangeTabAction;
    ActionTabHorario: TChangeTabAction;
    ActionTabFuncionario: TChangeTabAction;
    RESTClient1: TRESTClient;
    RESTRequest1: TRESTRequest;
    RESTResponse1: TRESTResponse;
    TabControl1: TTabControl;
    TabLogin: TTabItem;
    Rectangle1: TRectangle;
    LytDown: TLayout;
    Layout3: TLayout;
    Image1: TImage;
    RctSenha: TRectangle;
    LblSenha: TLabel;
    RctConta: TRectangle;
    LblConta: TLabel;
    RctFacebook: TRectangle;
    RctFaceBt: TRectangle;
    SBtFacebook: TSpeedButton;
    RctOu: TRectangle;
    RctOu2: TRectangle;
    Label2: TLabel;
    Layout18: TLayout;
    Layout19: TLayout;
    Rectangle6: TRectangle;
    BtnEnter: TSpeedButton;
    Layout16: TLayout;
    Layout17: TLayout;
    Rectangle5: TRectangle;
    EditPassword: TEdit;
    Layout2: TLayout;
    Layout4: TLayout;
    Rectangle2: TRectangle;
    EditEmail: TEdit;
    TabConfiguracao: TTabItem;
    Rectangle10: TRectangle;
    Layout7: TLayout;
    Rectangle3: TRectangle;
    Layout8: TLayout;
    Rectangle12: TRectangle;
    SpeedButton2: TSpeedButton;
    Rectangle47: TRectangle;
    Label1: TLabel;
    Label3: TLabel;
    Layout14: TLayout;
    Rectangle14: TRectangle;
    Layout15: TLayout;
    Rectangle15: TRectangle;
    SpeedButton5: TSpeedButton;
    Rectangle35: TRectangle;
    SpeedButton6: TSpeedButton;
    Rectangle36: TRectangle;
    SpeedButton15: TSpeedButton;
    Rectangle37: TRectangle;
    SpeedButton16: TSpeedButton;
    Rectangle38: TRectangle;
    SpeedButton17: TSpeedButton;
    Layout28: TLayout;
    Layout29: TLayout;
    Layout30: TLayout;
    Rectangle54: TRectangle;
    Layout31: TLayout;
    Rectangle55: TRectangle;
    Label12: TLabel;
    TabAgenda: TTabItem;
    Rectangle4: TRectangle;
    Layout10: TLayout;
    Rectangle26: TRectangle;
    Layout22: TLayout;
    Rectangle27: TRectangle;
    SpeedButton10: TSpeedButton;
    Rectangle28: TRectangle;
    SpeedButton11: TSpeedButton;
    Rectangle29: TRectangle;
    SpeedButton12: TSpeedButton;
    Rectangle30: TRectangle;
    SpeedButton13: TSpeedButton;
    Rectangle31: TRectangle;
    SpeedButton23: TSpeedButton;
    Layout6: TLayout;
    Rectangle23: TRectangle;
    Layout9: TLayout;
    Rectangle24: TRectangle;
    SpeedButton9: TSpeedButton;
    Rectangle48: TRectangle;
    Label4: TLabel;
    Label5: TLabel;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  FrmLogin: TFrmLogin;

implementation

{$R *.fmx}
{$R *.NmXhdpiPh.fmx ANDROID}

end.
