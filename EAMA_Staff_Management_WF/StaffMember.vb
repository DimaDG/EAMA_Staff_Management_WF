Public Class StaffMember
    Public Fname As String
    Public SName As String
    Public Tname As String
    Public ID As Integer        'уникален идентификатор на всеки назначен служител
    Public dirID As Integer     'идентификатор на дирекция
    Public depID As Integer     'идентификатор на отдел
    Public posID As Integer     'идентификатор на заеманата длъжност
    Public pref As String       'префикс на лицето - проф., д-р, доц., инж.
    Public EGN As String
    Public DoB As Date          'дата на раждане
    Public telext As String     'вътрешен номер в телефонния указател
    Public GSM As String        'служебен номер на мобилния телефон
    Public eMailW As String     'служебен пощенски адрес
    Public eMailP As String     'частен пощенски адрес
    Public ShowName As String   'името което да се показва в сортиращите списъци
    Public role As Integer      'роля в екипа която може да заема - 1=председател + член, 2=само член, 3=не участва в проверки
    Public AppOrd As Integer    'позиция в списъка на съгласувателите на документи
    Public OccType As String    'начин на заемане на длъжността - f=пълно рв, p=частично рв, fp=пълно рв + съвместителство
    Public active As String     'текущо заема длъжността - Y/N
    Public DtStart As Date      'дата на назначаване в агенцията
    Public DtEnd As Date        'дата на напускане на агенцията
    Public note As String       'забележка
End Class
