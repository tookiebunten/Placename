# Placenames
Somewhere to dump my place-name notes and research. I have multiple files, spreadsheets and notes all over the place. It needs to be searchable and ultimately be able to load into GIS software like QGIS. Either as a csv or possibly a WMT layer or such like

## Data tables

![alt text](https://github.com/tookiebunten/Placenames/blob/4c8703430da410da1bb6132d9a7657f4c64539bd/images/Drawing1.png)

## Data table structure
Structure of tables and example data

### placename

| idx | name_id | name | nation | region | parish | parish_short |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| interger | varchar | varchar | varchar | varchar |  varchar | varchar |
| 1 | 001 | Draffan | Scotland | South Lanarkshire | Lesmahagow | LEW |

### placename_variations 

| idx | name_id | variation_id | spelling | source | source_date | comments |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| interger | placename.name_id | integer | varchar | varchar | number | varchar |
| 1 | 001 | 1 | Dreffan | Timothy Pont | 1596 | Online map at https://maps.nls.uk/ |
| 2 | 001 | 2 |Drafan | William Forrest | 1816 | Online map at https://maps.nls.uk/ |

### placename_coordinates

| idx | name_id | os_sheet | os_grid_10 | osgb_east | osgb_north | easting(x) | northing(y) | longitude | latitude |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| integer | placename.name_id | varchar | varchar | varchar | varchar | varchar | varchar | varchar | varchar |
| 1 | 001 | NS | NS7952545308 | 281315.0351 |	637168.5919 | 281315 | 637168 | -3.885855675 | 55.61358949 |

### placename_notes

|idx | name_id | variation_id | notes |
| :---: | :---: | :---: | :---: 
| interger | placename.name_id | interger | varchar |
| 1 | 001 | 2 | anything that does fit in placename_variations.comments |

