$(function(e) {

    //______Basic Data Table
    //$('#basic-datatable').DataTable({
    //    language: {
    //        searchPlaceholder: 'Search...',
    //        sSearch: '',
    //    }
    //});


    //______Basic Data Table
    $('#responsive-datatable').DataTable({
        language: {
            searchPlaceholder: 'Tìm kiếm',
            scrollX: "100%",
            sSearch: '',
            emptyTable: "Không có dữ liệu",
            "info": "Hiện _START_ đến _END_ của _TOTAL_ dữ liệu",
            "infoEmpty": "Hiện 0 đến 0 của 0 dữ liệu",
            "infoFiltered": "(Tìm kiếm trong _MAX_ dữ liệu)",
            "lengthMenu": "Hiển thị _MENU_ dữ liệu   ",
            "zeroRecords": "Không tìm thấy dữ liệu phù hợp",
            "paginate": {
            "first": "Đầu tiên",
                "last": "Cuối cùng",
                "next": "Tiếp",
                "previous": "Trước"
        }
        }
       
    });
  
    //______File-Export Data Table
    //var table = $('#file-datatable').DataTable({
    //    buttons: ['copy', 'excel', 'pdf', 'colvis'],
    //    language: {
    //        searchPlaceholder: 'Search...',
    //        scrollX: "100%",
    //        sSearch: '',
    //    }
    //});
    //table.buttons().container()
    //    .appendTo('#file-datatable_wrapper .col-md-6:eq(0)');

    ////______Delete Data Table
    //var table = $('#delete-datatable').DataTable({
    //    language: {
    //        searchPlaceholder: 'Search...',
    //        sSearch: '',
    //    }
    //});
    //$('#delete-datatable tbody').on('click', 'tr', function() {
    //    if ($(this).hasClass('selected')) {
    //        $(this).removeClass('selected');
    //    } else {
    //        table.$('tr.selected').removeClass('selected');
    //        $(this).addClass('selected');
    //    }
    //});
    //$('#button').click(function() {
    //    table.row('.selected').remove().draw(false);
    //});
    //$('#example3').DataTable( {
    //    responsive: {
    //        details: {
    //            display: $.fn.dataTable.Responsive.display.modal( {
    //                header: function ( row ) {
    //                    var data = row.data();
    //                    return 'Details for '+data[0]+' '+data[1];
    //                }
    //            } ),
    //            renderer: $.fn.dataTable.Responsive.renderer.tableAll( {
    //                tableClass: 'table'
    //            } )
    //        }
    //    }
    //} );
 //   $('#example2').DataTable({
	//	responsive: true,
	//	language: {
	//		searchPlaceholder: 'Search...',
	//		sSearch: '',
	//		lengthMenu: '_MENU_ items/page',
	//	}
	//});
	

    //______Select2 
    $('.select2').select2({
        minimumResultsForSearch: Infinity
    });

});