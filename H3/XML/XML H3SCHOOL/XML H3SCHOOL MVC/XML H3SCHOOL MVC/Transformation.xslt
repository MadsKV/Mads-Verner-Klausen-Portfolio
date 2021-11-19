<?xml version='1.0'?>
<xsl:stylesheet version="1.0"
      xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="xml" encoding="utf-8"/>
  <xsl:template match="/">
    <xsl:variable name="root_path" select="/school" />
    <school>
      <teams>
        <xsl:for-each select="$root_path/teams/team">
          <xsl:copy-of select="."/>
        </xsl:for-each>
      </teams>
      <classrooms>
        <xsl:for-each select="$root_path/classrooms/classroom">
          <xsl:copy-of select="."/>
        </xsl:for-each>
      </classrooms>
    </school>
  </xsl:template>
</xsl:stylesheet>