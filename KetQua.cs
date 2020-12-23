using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decision_Tree_ID3
{
    public partial class KetQua : Form
    {
        public KetQua()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (Buoi.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn buổi!");
            }
            else if (Thu.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn thứ!");
            }
            else if (Ngay.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn ngày!");
            }
            else if (quangCanh.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn quang cảnh!");
            }
            else if (Gio.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn mức gió!");
            }
            else if (doAm.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn độ ẩm!");
            }
            else if (Mua.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn mùa!");
            }
            else if (nhietDo.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn nhiệt độ!");
            }
            else if (Ngay.SelectedItem.ToString() == "Lễ")
            {
                if(doAm.SelectedItem.ToString() == "Cao")
                {
                    if(quangCanh.SelectedItem.ToString() == "Nắng")
                    {
                        MessageBox.Show("Ngày hôm nay đông khách!");
                    } else if(quangCanh.SelectedItem.ToString() == "Âm u")
                    {
                        MessageBox.Show("Ngày hôm nay rất đông khách!");
                    } else if(quangCanh.SelectedItem.ToString() == "Mưa")
                    {
                        MessageBox.Show("Ngày hôm nay đông khách!");
                    }

                } else if(doAm.SelectedItem.ToString() == "Trung Bình")
                {
                    MessageBox.Show("Ngày hôm nay đông khách!");
                } else if (doAm.SelectedItem.ToString() == "Thấp")
                {
                    if(Gio.SelectedItem.ToString() == "Nhẹ")
                    {
                        MessageBox.Show("Ngày hôm nay rất đông khách!");
                    } else if (Gio.SelectedItem.ToString() == "Mạnh")
                    {
                        MessageBox.Show("Ngày hôm nay đông khách!");
                    }
                }
            } else if (Ngay.SelectedItem.ToString() == "Thường")
            {
                 if (Thu.SelectedItem.ToString() == "Ba")
                 {
                     if (nhietDo.SelectedItem.ToString() == "Nóng")
                     {
                         MessageBox.Show("Ngày hôm nay vắng khách!");
                     } else if(nhietDo.SelectedItem.ToString() == "Mát")
                     {
                         MessageBox.Show("Ngày hôm nay đông khách!");
                     } else if (nhietDo.SelectedItem.ToString() == "Lạnh")
                     {
                         MessageBox.Show("Ngày hôm nay đông khách!");
                     }
                 } else if(Thu.SelectedItem.ToString() == "Năm")
                 {
                    if(Buoi.SelectedItem.ToString() == "Sáng")
                    {
                        MessageBox.Show("Sáng hôm nay vắng khách!");
                    }
                    else if (Buoi.SelectedItem.ToString() == "Trưa")
                    {
                        MessageBox.Show("Trưa hôm nay đông khách!");
                    }
                    else if (Buoi.SelectedItem.ToString() == "Tối")
                    {
                        MessageBox.Show("Tối hôm nay rất đông khách!");
                    }
                } else if(Thu.SelectedItem.ToString() == "Bảy")
                {
                    if(doAm.SelectedItem.ToString() == "Trung Bình")
                    {
                        MessageBox.Show("Ngày hôm nay đông khách!");
                    } else if (doAm.SelectedItem.ToString() == "Cao")
                    {
                        MessageBox.Show("Ngày hôm nay rất đông khách!");
                    }
                } else if(Thu.SelectedItem.ToString() == "Hai")
                {
                    MessageBox.Show("Ngày hôm nay rất đông khách!");
                } else if(Thu.SelectedItem.ToString() == "Sáu")
                {
                    MessageBox.Show("Ngày hôm nay đông khách!");
                } else if(Thu.SelectedItem.ToString() == "Tư")
                {
                    MessageBox.Show("Ngày hôm nay vắng khách!");
                }
                else if (Thu.SelectedItem.ToString() == "Chủ nhật")
                {
                    MessageBox.Show("Ngày hôm nay rất đông khách!");
                }
            } 
        }

        private void btn_lauChon_Click(object sender, EventArgs e)
        {
            if (cbb_luachon.SelectedItem == cbb_luachon.Items[0])
            {
                string str1 = Environment.NewLine + "   Buffet là hình thức ăn uống có nguồn gốc từ phương Tây, trong tiếng Pháp, Buffet có nghĩa là tự chọn hay còn gọi là “tiệc đứng”. Ý nghĩa của tên gọi cũng là một lời giải thích cho loại hình ăn uống này. Buffet là hình thức ăn theo suất, trả tiền trọn gói nên nhà hàng tính tiền theo số lượng người mà không phân biệt bạn ăn món gì, ăn nhiều hay ăn ít. Trong các buổi tiệc Buffet thường sẽ có rất nhiều món để bạn tự chọn lựa, thậm chí bạn có thể ăn bao nhiêu tùy thích và bạn có thể đi lại, đứng ngồi khi ăn uống.";
                string str2 = Environment.NewLine + "   Vào thế kỷ XVIII, ở Pháp bắt đầu xuất hiên những bữa tiệc ngoài trời phục vụ một số lượng lớn khách mời, với những dãy bàn dài bày sẵn đồ ăn. Sau đó, hình thức này phổ biến sang Anh và các nước châu Âu. Mãi đến giữa thế kỷ XIX, người Mỹ mới biết đến loại hình Buffet này, nhờ sự sáng tạo của một nhà hàng Trung Quốc mở trên đất Mỹ. Từ đó, Buffet trở nên đặc biệt thịnh hành ở Mỹ vào những năm 1930 với nhiều biến tấu hiện đại. Và giờ đây, Buffet đã phát triển rộng rãi trên khắp thế giới.";
                txt_thongTin.Text = "   Buffet Là Gì?" + str1 + str2;
            }
            if (cbb_luachon.SelectedItem == cbb_luachon.Items[1])
            {
                string str1 = Environment.NewLine + "   Bất kể là bữa trưa hay bữa tối thì bạn cũng không thể bỏ ra một số tiền để ăn buffet khi mà không có thời gian thưởng thức. Tối thiểu khi bạn muốn ăn buffet hãy dành ra 2 tiếng cho bữa tiệc của mình. Đơn giản là vì ăn buffet không cần ăn nhanh lấy thưởng mà là ăn từ từ để thưởng thức cũng như có thời gian trò chuyện cùng bạn bè, người thân đi cùng.";
                string str2 = Environment.NewLine + "   Vậy nên chọn ăn buffet  trưa hay buffet buổi tối còn tùy thuộc vào thời gian rảnh của bạn.";
                txt_thongTin.Text = "   Thời điểm nào đi ăn buffet là hợp lý nhất?" + str1 + str2;
            }
            if (cbb_luachon.SelectedItem == cbb_luachon.Items[2])
            {
                string str1 = Environment.NewLine + "   Nếu bạn thuộc team hải sản thì còn chần chừ gì nữa. Hãy đến ngay buffet hải sản trưa giá rẻ, có rất nhiều loại hải sản hấp dẫn đang chào đón bạn. Bạn sẽ tha hồ thưởng thức các món ăn hấp dẫn từ các loại hải sản tươi sống mà không phải lo ngại về lượng protein, calo lớn từ tôm, cua, cá, ốc, sò, hàu biển…Vì bạn có thể đốt cháy lượng calo thừa ấy trong cả ngày dài làm việc.";
                string str0 = Environment.NewLine + "   Vậy nếu bạn yêu thích BBQ thì sao? Không khí mát mẻ buổi tối cùng với sức hấp dẫn của hàng có hàng chục món nướng đủ loại làm bạn không thể không đến với buffet tối giá rẻ.";
                string str2 = Environment.NewLine + "   Buổi tối không khí dễ chịu, mát mẻ thế này, tụ tập bạn bè cùng ăn buffet nướng thì quá tuyệt vời rồi!";
                txt_thongTin.Text = "  Món ăn yêu thích khi ăn buffet trưa hay buffet tối là gì?" + str1 + str0 + str2;
            }
            if (cbb_luachon.SelectedItem == cbb_luachon.Items[3])
            {
                string str1 = Environment.NewLine + "   Đa số mọi người đi ăn buffet cùng gia đình, bạn bè, đồng nghiệp…Vậy người đi cùng bạn là nhân tố quan trọng ảnh hưởng quyết định lựa chọn thời gian ăn buffet của bạn. ";
                string str2 = Environment.NewLine + "   Đối với những người trong gia đình, ắt hẳn có trẻ em và người lớn tuổi mà trẻ em thì ngủ rất sớm còn người già hay mắc chứng mất ngủ nên cũng không ngoại lệ. Vì thế, buffet ăn trưa luôn là lựa chọn hàng đầu của các gia đình. ";
                string str3 = Environment.NewLine + "   Còn đối với bạn bè, đồng nghiệp thì buffet buổi tối là ưu tiên số một vì ban ngày, ai nấy bận việc ở công ty, chỉ có thể tụ tập, gặp gỡ vào buổi tối.";
                txt_thongTin.Text = "  Ai là người đi ăn buffet cùng bạn? " + str1 + str2 + str3;
            }
            if (cbb_luachon.SelectedItem == cbb_luachon.Items[4])
            {
                string str1 = Environment.NewLine + "   Đi ăn buffet để thưởng thức thì không vấn đề gì cả.";
                string str2 = Environment.NewLine + "   Tuy nhiên, ngày nay nhịp sống hối hả, mọi người chạy đua với thời gian kể cả trong các bữa ăn. Họ dùng bàn ăn làm nơi giải quyết công việc, thảo luận các vấn đề công việc, tiệc buffet cũng không ngoại lệ.";
                string str3 = Environment.NewLine + "   Thường sau các buổi hội họp công ty, giám đốc sẽ mời nhân viên ăn buffet, vừa ăn vừa có thể bàn luận về vấn đề của công ty nên buổi trưa khá thuận lợi và hiệu quả. Còn khi mời các đối tác làm việc thì buổi tốt là thời điểm thích hợp dùng tiệc buffet. Thường thì họ có thời gian rảnh nhiều hơn buổi trưa nên có nhiều thời gian hơn bàn chuyện công việc, thỏa thuận làm ăn của hai bên.";
                txt_thongTin.Text = "  Bạn đi ăn buffet với mục đích gì?" + str1 + str2 + str3;
            }
            if (cbb_luachon.SelectedItem == cbb_luachon.Items[5])
            {
                string str1 = Environment.NewLine + "   Thời tiết là một yếu tố khách quan nhưng cũng không kém phần quan trọng cho quyết định của bạn. Khi thời tiết se lạnh vào buổi tối thì còn gì tuyệt vời hơn những buổi buffet nướng lẩu, cùng nhau nhâm nhi cùng nhau trò chuyện sẽ làm bạn thấy ấm áp hơn bao giờ hết.";
                txt_thongTin.Text = "  Thời tiết có ảnh hưởng đến việc bạn chọn buffet trưa hay buffet tối?" + str1;
            }
            if (cbb_luachon.SelectedItem == cbb_luachon.Items[6])
            {
                string str1 = Environment.NewLine + "   – Không nên lấy quá nhiều thức ăn cùng lúc, làm mất phần của người khác hoặc nếu ăn không hết sẽ phải đổ đi. Vì thế, nên lấy lượng thức ăn vừa đủ, mỗi loại một ít, có thể lấy một ít đồ ăn, ăn hết rồi lại tiếp tục lấy.";
                string str2 = Environment.NewLine + "   – Nếu thấy có những món ăn lạ, nên lấy trước một ít ăn thử, nếu món ăn hợp với khẩu vị mới lấy thêm. Nếu bạn cứ thích lấy thật nhiều nhưng không ăn lại bỏ đi rất lãng phí.";
                string str3 = Environment.NewLine + "   – Không nên ăn quá nhanh mà ăn một cách chậm rãi, vừa thưởng thức món ăn vừa nói chuyện với bạn bè và những ngưởi xung quanh.";
                string str4 = Environment.NewLine + "   – Và quan trọng không được để thừa thức ăn. Vì khi ăn Buffet, bạn được tự quyền quyết định món ăn và lượng thức ăn, vì vậy ăn Buffet đúng cách không cho phép bạn để thừa thức ăn.";
                string str5 = Environment.NewLine + "   – Không nên ngại ngần đi lại để lấy thức ăn, đồ uống. Tuy nhiên, khi đi lại phải giữ trật tự và cẩn thận để không làm đổ thức ăn vào người khác.";
                txt_thongTin.Text = "  Cách Ăn Buffet Đúng Cách" + str1 + str2 + str3 + str4 + str5;
            }
            if (cbb_luachon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn kìa?", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_thongTin.Text = null;
            }
        }

        private void btn_huongdan_Click(object sender, EventArgs e)
        {
            HuongDan hd = new HuongDan();
            hd.ShowDialog();
        }

        private void btn_quanliluat_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTin f2 = new ThongTin();
            f2.ShowDialog();
        }

        private void KetQua_Load(object sender, EventArgs e)
        {
            myLabel.Text = DateTime.Now.ToString("dddd , MMM dd yyyy, hh:mm");
        }
    }
}
