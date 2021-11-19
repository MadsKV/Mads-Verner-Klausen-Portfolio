<xsl:output method="xml" encoding="utf-8"/>
<xsl:template match="/">
  <!--<xsl:variable name="StudentCount" select="count(/techCollage/students/student)"/>
    <xsl:variable name="StudentTotal" select="sum(/techCollage/students/student/age)"/>
    <xsl:variable name="StudentAverageAge" select="$StudentTotal div $StudentCount"/>

    <xsl:variable name="TeacherCount" select="count(/techCollage/teachers/teacher)"/>
    <xsl:variable name="TeacherTotal" select="sum(/techCollage/teachers/teacher/age)"/>
    <xsl:variable name="TeacherAverageAge" select="$TeacherTotal div $TeacherCount"/>-->
  <techcollage>
    <students>
      <!--Books That Cost Below Average-->
      <xsl:for-each select="/techCollage/students/student">
        <xsl:copy-of select="."/>
      </xsl:for-each>
    </students>
    <teachers>
      <!--Books That Cost Below Average-->
      <xsl:for-each select="/techCollage/teachers/teacher">
        <xsl:copy-of select="."/>
      </xsl:for-each>
    </teachers>
    <classes>
      <!--Books That Cost Below Average-->
      <xsl:for-each select="/techCollage/classes/class">
        <xsl:copy-of select="."/>
      </xsl:for-each>
    </classes>
  </techcollage>
</xsl:template>
</xsl:stylesheet>
