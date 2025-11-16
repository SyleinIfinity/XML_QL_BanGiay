<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  
  <xsl:template match="/">

    <html>
      <head>
        <style>
          body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f9;
            margin: 0;
            padding: 20px;
          }
          h2 {
            text-align: center;
            color: #333;
            margin-bottom: 30px;
          }
          table {
            width: 100%;
            border-collapse: collapse;
            margin: 0 auto;
            box-shadow: 0px 4px 6px rgba(0, 0, 0, 0.1);
          }
          th, td {
            padding: 12px;
            text-align: left;
            border: 1px solid #ddd;
            font-size: 14px;
          }
          th {
            background-color: #4CAF50;
            color: white;
          }
          td {
            background-color: #f9f9f9;
          }
          tr:nth-child(even) td {
            background-color: #f2f2f2;
          }
          tr:hover td {
            background-color: #ddd;
          }
          td:nth-child(5) {
            text-align: right;
          }
          .total-row {
            font-weight: bold;
            background-color: #f4f4f9;
            text-align: right;
          }
          .total-label {
            font-size: 16px;
          }
          .total-amount {
            font-size: 16px;
            color: #ff5722;
          }
        </style>
      </head>
      <body>
        <h2>Hoá Đơn</h2>
        
        <p><xsl:value-of select="HoaDon/mahoadon"/> </p>
        <p><xsl:value-of select="HoaDon/manhanvien"/> </p>
        <p><xsl:value-of select="HoaDon/tenkhachhang"/> </p>
        <p><xsl:value-of select="HoaDon/ngaytao"/> </p>

        <table>
          <tr>
            <th>Mã giày</th>
            <th>Số lượng đặt</th>
            <th>Đơn giá</th>
            <th>Thành tiền</th>
          </tr>
          <xsl:for-each select="HoaDon/ChiTietHoaDon">
            <tr>
              <td><xsl:value-of select="magiay"/></td>
              <td><xsl:value-of select="soluong"/></td>
              <td><xsl:value-of select="dongia" /></td>
              <td>
                <xsl:value-of select="format-number(soLuong * dongia, '#,##0.00')"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>

        <!-- Tổng tiền -->
        <table>
          <tr>
            <td colspan="3">Tổng tiền hóa đơn:</td>
            <td>
              <xsl:value-of select="format-number(sum(HoaDon/ChiTietHoaDon/soLuong * HoaDon/ChiTietHoaDon/dongia), '#,##0.00')"/>
            </td>
          </tr>
        </table>

      </body>
    </html>

  </xsl:template>

</xsl:stylesheet>
    