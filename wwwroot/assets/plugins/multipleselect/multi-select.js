(function ($) {
	"use strict";
	//basic
	$('.multi-select').multipleSelect({
		selectAllText: 'Chọn tất cả',
		allSelected: 'Đang chọn tất cả',
		countSelected: '# trong % lựa chọn',
		noMatchesFound: 'Không có dữ liệu',
	});

	//optiongroup
	$('.optmulti-select').multipleSelect({
		multiple: true,
		multipleWidth: 55,
		width: '100%',
		selectAllText: 'Chọn tất cả',
		allSelected: 'Đang chọn tất cả',
		countSelected: '# trong % lựa chọn',
		noMatchesFound: 'Không có dữ liệu',
	});

	//Multiple Items
	$('.multiselect').multipleSelect({
		width: 460,
		multiple: true,
		multipleWidth: 55,
		selectAllText: 'Chọn tất cả',
		allSelected: 'Đang chọn tất cả',
		countSelected: '# trong % lựa chọn',
		noMatchesFound: 'Không có dữ liệu',
	});

	//hide selectall
	$('.hide-select').multipleSelect({
		selectAll: false,
		selectAllText: 'Chọn tất cả',
		allSelected: 'Đang chọn tất cả',
		countSelected: '# trong % lựa chọn',
		noMatchesFound: 'Không có dữ liệu',
	});

	//Single Row
	$('.single-select').multipleSelect({
		single: true,
		selectAllText: 'Chọn tất cả',
		allSelected: 'Đang chọn tất cả',
		countSelected: '# trong % lựa chọn',
		noMatchesFound: 'Không có dữ liệu',
	});

	//filter-multiple
	$('.filter-multi').multipleSelect({
		filter: true,
		selectAllText: 'Chọn tất cả',
		allSelected: 'Đang chọn tất cả',
		countSelected: '# trong % lựa chọn',
		noMatchesFound: 'Không có dữ liệu',


	})

	//group-filter
	$('.group-filter').multipleSelect({
		filter: true,
		multiple: true,
		selectAllText: 'Chọn tất cả',
		allSelected: 'Đang chọn tất cả',
		countSelected: '# trong % lựa chọn',
		noMatchesFound: 'Không có dữ liệu',
	});

	//custom
	$('.custom-multiselect').multipleSelect({
		styler: function (value) {
			if (value == '1') {
				return 'background-color: #5e2dd8 ; color: #ffffff;';
			}
			if (value == '6') {
				return 'background-color: #32cafe; color: #ffffff;';
			}
			if (value == '10') {
				return 'background-color: #ff7088; color: #ffffff;';
			}
		}
	});

})(jQuery);
